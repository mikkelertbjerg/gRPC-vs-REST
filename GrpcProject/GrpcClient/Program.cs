using Grpc.Core;
using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            TextModel t;
            Stopwatch stopwatch = new Stopwatch();
            TimeSpan ts;
            string elapsedTime;

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var textClient = new Text.TextClient(channel);

            //Hacky way to open the connection
            await textClient.GetTextAsync(new TextId { Id = 0 });

            //Start testing
            stopwatch.Start();
            using (var requestAllTexts = textClient.GetAllTexts(new EmptyRequest()))
            {
                while (await requestAllTexts.ResponseStream.MoveNext())
                {
                    t = requestAllTexts.ResponseStream.Current;
                }
            }
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine("RunTime: " + elapsedTime);


            Random rng = new Random();
            int randomId = rng.Next(101);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine($"Getting Text with id: {randomId}");
            await textClient.GetTextAsync(new TextId { Id =  randomId});
            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine("RunTime: " + elapsedTime);

            Console.ReadLine();
        }
    }
}
