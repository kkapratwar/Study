// See https://aka.ms/new-console-template for more information
using Calculator;
using Grpc.Core;

const string target = "127.0.0.1:50051";

Channel channel = new Channel(target, ChannelCredentials.Insecure);

channel.ConnectAsync().ContinueWith((task) =>
{
    if (task.Status == TaskStatus.RanToCompletion)
        Console.WriteLine("The client connected successfully");
});

var client = new CalculatorService.CalculatorServiceClient(channel);

var result = client.Sum(new SumRequest { A = 10, B = 20 });

Console.WriteLine($"Sum of two numbers = {result.Result}");

channel.ShutdownAsync().Wait();
Console.ReadKey();