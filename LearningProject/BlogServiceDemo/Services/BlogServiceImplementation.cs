using AutoMapper;
using Grpc.Core;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BlogServiceDemo.Services
{
    public class BlogServiceImplementation : BlogService.BlogServiceBase
    {
        private static MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase mongoDatabase = mongoClient.GetDatabase("Mydb");
        private static IMongoCollection<Models.Blog> mongoCollection = mongoDatabase.GetCollection<Models.Blog>("blog");
        private readonly IMapper mapper;

        public BlogServiceImplementation(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public override Task<CreateBlogResponse> CreateBlog(CreateBlogRequest request, ServerCallContext context)
        {
            var blog = mapper.Map<Models.Blog>(request.Blog);

            mongoCollection.InsertOne(blog);

            request.Blog.Id = blog.Id;

            return Task.FromResult(new CreateBlogResponse { Blog = request.Blog });
        }

        public override Task<GetBlogResponse> GetBlog(GetBlogRequest request, ServerCallContext context)
        {
            var blogModel = mongoCollection.Find(x => x.Id == request.Id).First();

            var blog = mapper.Map<Blog>(blogModel);

            return Task.FromResult(new GetBlogResponse { Blog = blog });
        }

        public override Task<UpdateBlogResponse> UpdateBlog(UpdateBlogRequest request, ServerCallContext context)
        {
            var blogModel = mongoCollection.Find(x => x.Id == request.Blog.Id).FirstOrDefault();

            if (blogModel != null)
            {
                blogModel.Title = request.Blog.Title;
                blogModel.Content = request.Blog.Content;
                blogModel.AuthorId = request.Blog.AuthorId;
            }

            mongoCollection.ReplaceOne(x => x.Id == request.Blog.Id, blogModel);

            var blog = mapper.Map<Blog>(blogModel);

            return Task.FromResult(new UpdateBlogResponse { Blog = blog });
        }

        public override Task<DeleteBlogResponse> DeleteBlog(DeleteBlogRequest request, ServerCallContext context)
        {
            var blogModel = mongoCollection.Find(x => x.Id == request.Id).FirstOrDefault();

            if (blogModel != null)
            {
                mongoCollection.DeleteOne(x => x.Id == request.Id);
            }

            return Task.FromResult(new DeleteBlogResponse { Message = $"Blog with id {request.Id} deleted successfully."});
        }
    }
}
