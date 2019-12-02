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
            MediumPayload mp;
            LargePayload lp;
            DeepPayload dp;
            DeeperPayload dper;
            DeepestPayload dpst;
            
            TimeSpan ts;
            TimeSpan dts;
            string elapsedTime;

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var payloadClient = new PayloadService.PayloadServiceClient(channel);

            //Verify payload objects
            PayloadId payloadId = new PayloadId { Id = 1 };
            SmallPayload smallPayload = await payloadClient.GetSmallPayloadAsync(payloadId);
            MediumPayload mediumPayload = await payloadClient.GetMediumPayloadAsync(payloadId);
            LargePayload largePyload = await payloadClient.GetLargePayloadAsync(payloadId);
            DeepPayload deepPayload = await payloadClient.GetDeepPayloadAsync(payloadId);
            DeeperPayload deeperPayload = await payloadClient.GetDeeperPayloadAsync(payloadId);
            DeepestPayload deepestPayload = await payloadClient.GetDeepestPayloadAsync(payloadId);

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
            stopwatch.Reset();

            //GetMediumPayload
            Console.WriteLine("Calling 'GetMediumPayload(Payload id)' 100 times");

            for (int i = 0; i < 100; i++)
            {
                stopwatch.Start();
                await payloadClient.GetMediumPayloadAsync(new PayloadId { Id = i });
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
            stopwatch.Reset();

            //GetLargePayload
            Console.WriteLine("Calling 'GetLargePayload(Payload id)' 100 times");

            for (int i = 0; i < 100; i++)
            {
                stopwatch.Start();
                await payloadClient.GetLargePayloadAsync(new PayloadId { Id = i });
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
            stopwatch.Reset();

            //GetDeepPayload
            Console.WriteLine("Calling 'GetDeepPayload(Payload id)' 100 times");

            for (int i = 0; i < 100; i++)
            {
                stopwatch.Start();
                await payloadClient.GetDeepPayloadAsync(new PayloadId { Id = i });
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
            stopwatch.Reset();

            //GetDeeperPayload
            Console.WriteLine("Calling 'GetDeeperPayload(Payload id)' 100 times");

            for (int i = 0; i < 100; i++)
            {
                stopwatch.Start();
                await payloadClient.GetDeeperPayloadAsync(new PayloadId { Id = i });
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
            stopwatch.Reset();

            //GetDeepestPayload
            Console.WriteLine("Calling 'GetDeepestPayload(Payload id)' 100 times");

            for (int i = 0; i < 100; i++)
            {
                stopwatch.Start();
                await payloadClient.GetDeepestPayloadAsync(new PayloadId { Id = i });
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
            stopwatch.Reset();

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
            stopwatch.Reset();

            //GetAllMediumPayloads
            Console.WriteLine("Calling 'GetAllMediumPayloads()' 100 times");

            for (int i = 0; i < 100; i++)
            {
                stopwatch.Start();
                using (var requestAllMediumPayloads = payloadClient.GetAllMediumPayloads(new EmptyRequest()))
                {
                    while (await requestAllMediumPayloads.ResponseStream.MoveNext())
                    {
                        mp = requestAllMediumPayloads.ResponseStream.Current;
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
            stopwatch.Reset();

            //GetAllLargePayloads
            Console.WriteLine("Calling 'GetAllLargePayloads()' 100 times");

            for (int i = 0; i < 100; i++)
            {
                stopwatch.Start();
                using (var requestAllLargePayloads = payloadClient.GetAllLargePayloads(new EmptyRequest()))
                {
                    while (await requestAllLargePayloads.ResponseStream.MoveNext())
                    {
                        lp = requestAllLargePayloads.ResponseStream.Current;
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
            stopwatch.Reset();

            //GetAllDeepPayloads
            Console.WriteLine("Calling 'GetAllDeepPayloads()' 100 times");

            for (int i = 0; i < 100; i++)
            {
                stopwatch.Start();
                using (var requestAllDeepPayloads = payloadClient.GetAllDeepPayloads(new EmptyRequest()))
                {
                    while (await requestAllDeepPayloads.ResponseStream.MoveNext())
                    {
                        dp = requestAllDeepPayloads.ResponseStream.Current;
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
            stopwatch.Reset();

            //GetAllDeeperPayloads
            Console.WriteLine("Calling 'GetAllDeeperPayloads()' 100 times");

            for (int i = 0; i < 100; i++)
            {
                stopwatch.Start();
                using (var requestAllDeeperPayloads = payloadClient.GetAllDeeperPayloads(new EmptyRequest()))
                {
                    while (await requestAllDeeperPayloads.ResponseStream.MoveNext())
                    {
                        dper = requestAllDeeperPayloads.ResponseStream.Current;
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
            stopwatch.Reset();

            //GetAllDeepestPayloads
            Console.WriteLine("Calling 'GetAllDeepestPayloads()' 100 times");

            for (int i = 0; i < 100; i++)
            {
                stopwatch.Start();
                using (var requestAllDeepestPayloads = payloadClient.GetAllDeepestPayloads(new EmptyRequest()))
                {
                    while (await requestAllDeepestPayloads.ResponseStream.MoveNext())
                    {
                        dpst = requestAllDeepestPayloads.ResponseStream.Current;
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
            stopwatch.Reset();


            Console.ReadLine();


        }
    }
}
