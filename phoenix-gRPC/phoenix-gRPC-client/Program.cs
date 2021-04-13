using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;

/*
 * https://docs.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-3.0&tabs=visual-studio
 * 
 * From Visual Studio, select Tools > NuGet Package Manager > Package Manager Console
 * From the Package Manager Console window, run cd phoenix-gRPC-client to change directories to the folder containing the phoenix-gRPC-client.csproj files.
 * Run the following commands:
 * Install-Package Grpc.Net.Client
 * Install-Package Google.Protobuf
 * Install-Package Grpc.Tools
 */

namespace phoenix_gRPC
{
    class Program
    {
        public static async Task HelloWorld()
        {
            Console.WriteLine("Hello World!");
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);

        }
        static void Main(string[] args)
        {
            Task.Delay(100000);
            HelloWorld().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
