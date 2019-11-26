using Grpc.Net.Client;
using Grpc.Core;
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
            Random rng = new Random();
            Stopwatch stopwatch = new Stopwatch();

            SmallPayload sp;
            
            TimeSpan ts;
            TimeSpan dts;
            string elapsedTime;

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var payloadClient = new PayloadService.PayloadServiceClient(channel);

            //Hacky way to open the connection
            await payloadClient.GetSmallPayloadAsync(new PayloadId { Id = 1 });

            //GetSmallPayload
            

            Console.WriteLine("Calling 'GetSmallPayload(Payload id)' 100 times");

            for (int i = 0; i < 100; i++)
            {
                stopwatch.Start();
                await payloadClient.GetSmallPayloadAsync(new PayloadId { Id = i });
                stopwatch.Stop();
            }

            ts = stopwatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine("Total run time (100 Calls): " + elapsedTime);
            dts = ts.Divide(100);
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            dts.Hours, dts.Minutes, dts.Seconds, dts.Milliseconds);
            Console.WriteLine("Average run time: " + elapsedTime);

            

            //GetAllSmallPayloads
            Console.WriteLine("Calling 'GetAllSmallPayloads()' 100 times");

            for (int i = 0; i < 100; i++)
            {
                stopwatch.Start();
                using (var requestAllSmallPayloads = payloadClient.GetAllSmallPayloads(new EmptyRequest()))
                {
                    while (await requestAllSmallPayloads.ResponseStream.MoveNext())
                    {
                        sp = requestAllSmallPayloads.ResponseStream.Current;
                    }
                }
                stopwatch.Stop();
            }

            ts = stopwatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine("Total run time (100 Calls): " + elapsedTime);
            dts = ts.Divide(100);
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            dts.Hours, dts.Minutes, dts.Seconds, dts.Milliseconds);
            Console.WriteLine("Average run time: " + elapsedTime);

            Console.ReadLine();


        }
    }
}
