using System;
using System.Diagnostics;

namespace TestClient
{
    class Program
    {

        static void Main(string[] args)
        {
            int selectedService = 0;
            int payloadNo = 0;
            Stopwatch stopWatch = new Stopwatch();
            
            string elapsedTime = "";
            Console.WriteLine("Test Client for our gRPC vs REST blogpost. \n" +
                                  "To see how we got our metrics follow the instructions given. \n" +
                                  "---------------------------------------------------------------\n" +
                                  "Press 1 for REST Payload Collections | Press 2 for REST Single Payloads");
            selectedService = int.Parse(Console.ReadLine());

            if (selectedService == 1)
            {
                RestConsumer restService = new RestConsumer();
                restService.Initialize();
                Console.WriteLine("-----------------\n" +
                                  "REST Payload Collections Selected. \n" +
                                  "-----------------\n" +
                                  "Type 1 for Small Payload | Press 2 for Medium Payload | Press 3 for Large Payload \n | Press 4 for Deep payload | Press 5 give Deeper Payload | Press 6 for Deepest Payload");
                payloadNo = int.Parse(Console.ReadLine());
                switch (payloadNo)
                {
                    case 1:
                        stopWatch.Start();
                        restService.RunPayload(payloadNo);
                        stopWatch.Stop();
                        TimeSpan ts = stopWatch.Elapsed;
                        elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
                        Console.WriteLine("Run Time: " + elapsedTime);
                        Console.WriteLine("Press any key to close the application.");
                        Console.ReadKey();
                        break;
                    case 2:
                        stopWatch.Start();
                        restService.RunPayload(payloadNo);
                        stopWatch.Stop();
                        TimeSpan ts2 = stopWatch.Elapsed;
                        elapsedTime = $"{ts2.Hours:00}:{ts2.Minutes:00}:{ts2.Seconds:00}.{ts2.Milliseconds / 10:00}";
                        Console.WriteLine("Run Time: " + elapsedTime);
                        Console.WriteLine("Press any key to close the application.");
                        Console.ReadKey();
                        break;
                    case 3:
                        stopWatch.Start();
                        restService.RunPayload(payloadNo);
                        stopWatch.Stop();
                        TimeSpan ts3 = stopWatch.Elapsed;
                        elapsedTime = $"{ts3.Hours:00}:{ts3.Minutes:00}:{ts3.Seconds:00}.{ts3.Milliseconds / 10:00}";
                        Console.WriteLine("Run Time: " + elapsedTime);
                        Console.WriteLine("Press any key to close the application.");
                        Console.ReadKey();
                        break;
                    case 4:
                        stopWatch.Start();
                        restService.RunPayload(payloadNo);
                        stopWatch.Stop();
                        TimeSpan ts4 = stopWatch.Elapsed;
                        elapsedTime = $"{ts4.Hours:00}:{ts4.Minutes:00}:{ts4.Seconds:00}.{ts4.Milliseconds / 10:00}";
                        Console.WriteLine("Run Time: " + elapsedTime);
                        Console.WriteLine("Press any key to close the application.");
                        Console.ReadKey();
                        break;
                    case 5:
                        stopWatch.Start();
                        restService.RunPayload(payloadNo);
                        stopWatch.Stop();
                        TimeSpan ts5 = stopWatch.Elapsed;
                        elapsedTime = $"{ts5.Hours:00}:{ts5.Minutes:00}:{ts5.Seconds:00}.{ts5.Milliseconds / 10:00}";
                        Console.WriteLine("Run Time: " + elapsedTime);
                        Console.WriteLine("Press any key to close the application.");
                        Console.ReadKey();
                        break;
                    case 6:
                        stopWatch.Start();
                        restService.RunPayload(payloadNo);
                        stopWatch.Stop();
                        TimeSpan ts6 = stopWatch.Elapsed;
                        elapsedTime = $"{ts6.Hours:00}:{ts6.Minutes:00}:{ts6.Seconds:00}.{ts6.Milliseconds / 10:00}";
                        Console.WriteLine("Run Time: " + elapsedTime);
                        Console.WriteLine("Press any key to close the application.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine($"Payload Index out of range: {payloadNo}. Has to be between 1-3.");
                        break;
                }
            }

            if (selectedService == 2)
            {
                RestConsumer restService = new RestConsumer();
                restService.Initialize();
                Console.WriteLine("-----------------\n" +
                                  "REST Specific Payload Selected. \n" +
                                  "-----------------\n" +
                                  "Type 1 for Small Payload | Press 2 for Medium Payload | Press 3 for Large Payload \n| Press 4 for Deep payload | Press 5 give Deeper Payload | Press 6 for Deepest Payload");
                payloadNo = int.Parse(Console.ReadLine());
                switch (payloadNo)
                {
                    case 1:
                        stopWatch.Start();
                        restService.RunSpecificPayload(payloadNo);
                        stopWatch.Stop();
                        TimeSpan ts = stopWatch.Elapsed;
                        elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
                        Console.WriteLine("Run Time: " + elapsedTime);
                        Console.WriteLine("Press any key to close the application.");
                        Console.ReadKey();
                        break;
                    case 2:
                        stopWatch.Start();
                        restService.RunSpecificPayload(payloadNo);
                        stopWatch.Stop();
                        TimeSpan ts2 = stopWatch.Elapsed;
                        elapsedTime = $"{ts2.Hours:00}:{ts2.Minutes:00}:{ts2.Seconds:00}.{ts2.Milliseconds / 10:00}";
                        Console.WriteLine("Run Time: " + elapsedTime);
                        Console.WriteLine("Press any key to close the application.");
                        Console.ReadKey();
                        break;
                    case 3:
                        stopWatch.Start();
                        restService.RunSpecificPayload(payloadNo);
                        stopWatch.Stop();
                        TimeSpan ts3 = stopWatch.Elapsed;
                        elapsedTime = $"{ts3.Hours:00}:{ts3.Minutes:00}:{ts3.Seconds:00}.{ts3.Milliseconds / 10:00}";
                        Console.WriteLine("Run Time: " + elapsedTime);
                        Console.WriteLine("Press any key to close the application.");
                        Console.ReadKey();
                        break;
                    case 4:
                        stopWatch.Start();
                        restService.RunSpecificPayload(payloadNo);
                        stopWatch.Stop();
                        TimeSpan ts4 = stopWatch.Elapsed;
                        elapsedTime = $"{ts4.Hours:00}:{ts4.Minutes:00}:{ts4.Seconds:00}.{ts4.Milliseconds / 10:00}";
                        Console.WriteLine("Run Time: " + elapsedTime);
                        Console.WriteLine("Press any key to close the application.");
                        Console.ReadKey();
                        break;
                    case 5:
                        stopWatch.Start();
                        restService.RunSpecificPayload(payloadNo);
                        stopWatch.Stop();
                        TimeSpan ts5 = stopWatch.Elapsed;
                        elapsedTime = $"{ts5.Hours:00}:{ts5.Minutes:00}:{ts5.Seconds:00}.{ts5.Milliseconds / 10:00}";
                        Console.WriteLine("Run Time: " + elapsedTime);
                        Console.WriteLine("Press any key to close the application.");
                        Console.ReadKey();
                        break;
                    case 6:
                        stopWatch.Start();
                        restService.RunSpecificPayload(payloadNo);
                        stopWatch.Stop();
                        TimeSpan ts6 = stopWatch.Elapsed;
                        elapsedTime = $"{ts6.Hours:00}:{ts6.Minutes:00}:{ts6.Seconds:00}.{ts6.Milliseconds / 10:00}";
                        Console.WriteLine("Run Time: " + elapsedTime);
                        Console.WriteLine("Press any key to close the application.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine($"Payload Index out of range: {payloadNo}. Has to be between 1-3.");
                        break;
                }
            }


        }
    }
}
