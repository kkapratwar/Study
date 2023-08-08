// See https://aka.ms/new-console-template for more information
using Calculator;
using Grpc.Core;
using server.services;

const int Port = 50051;

Server server = null;

try
{
    server = new Server()
    {
        Services = { CalculatorService.BindService(new CalculatorServiceImplementation()) },
        Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
    };
    server.Start();

    Console.WriteLine($"The server is listening on the Port : {Port}");
    Console.ReadKey();
}
catch (IOException e)
{
    Console.WriteLine($"The server failed to start : {e.Message}");
    throw;
}
finally
{
    if (server != null)
        server.ShutdownAsync().Wait();
}
