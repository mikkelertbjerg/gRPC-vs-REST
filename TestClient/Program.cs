using System;
using System.Diagnostics;

namespace TestClient
{
    class Program
    {

        static void Main(string[] args)
        {
            int selectedVersion = 0;
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Test Client for our gRPC vs REST blogpost. \n" +
                                  "To see how we got our metrics follow the instructions given. \n" +
                                  "---------------------------------------------------------------\n" +
                                  "Press 1 for REST Metrics | Press 2 for gRPC Metrics");
            selectedVersion = int.Parse(Console.ReadLine());
            switch (selectedVersion)
            {
                case 1:
                    RestConsumer rest = new RestConsumer();
                    stopWatch.Start();
                    rest.Initialize();
                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;

                    string elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
                    Console.WriteLine("Run Time: " + elapsedTime);
                    Console.WriteLine("Press any key to close the application.");
                    Console.ReadKey();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
