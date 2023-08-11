using AutoMapper;

namespace BlogServiceDemo.MapperProfiles
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<Models.Blog, Blog>().ReverseMap();
        }
    }
}
