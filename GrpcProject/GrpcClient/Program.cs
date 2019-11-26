using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SmallPayload sp;
            Stopwatch stopwatch = new Stopwatch();
            TimeSpan ts;
            TimeSpan dts;
            string elapsedTime;

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var payloadClient = Payload.PayloadClient();

            ////Hacky way to open the connection
            //await textClient.GetTextAsync(new TextId { Id = 0 });

            ////Start testing
            //Console.WriteLine("Starting 100 'GetAllText()' calls");

            //for (int i = 0; i < 100; i++)
            //{
            //    stopwatch.Start();
            //    using (var requestAllTexts = textClient.GetAllTexts(new EmptyRequest()))
            //    {
            //        while (await requestAllTexts.ResponseStream.MoveNext())
            //        {
            //            t = requestAllTexts.ResponseStream.Current;
            //        }
            //    }
            //    stopwatch.Stop();
            //}

            //ts = stopwatch.Elapsed;
            //elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            //Console.WriteLine("Total run time (100 Calls): " + elapsedTime);
            //dts = ts.Divide(100);
            //elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //dts.Hours, dts.Minutes, dts.Seconds, dts.Milliseconds);
            //Console.WriteLine("Average run time: " + elapsedTime);

            ////Prepare next test
            //Random rng = new Random();

            //Console.WriteLine("Starting 100 'GetText(TextId id)' calls");

            //for (int i = 0; i < 100; i++)
            //{
            //    int randomId = rng.Next(101);
            //    stopwatch.Start();
            //    await textClient.GetTextAsync(new TextId { Id = randomId });
            //    stopwatch.Stop();
            //}

            //ts = stopwatch.Elapsed;
            //elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            //Console.WriteLine("Total run time (100 Calls): " + elapsedTime);
            //ts.Divide(100);
            //elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //dts.Hours, dts.Minutes, dts.Seconds, dts.Milliseconds);
            //Console.WriteLine("Average run time: " + elapsedTime);

            //Console.ReadLine();
        }
    }
}
