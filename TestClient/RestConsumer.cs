using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TestClient
{
    public class RestConsumer
    {
        private string _url = "http://localhost:60264/api/";
        public HttpClient Client { get; set; }

        public string URL
        {
            get => _url;
            set => _url = value;
        }


        public void Initialize()
        {
            HttpClient httpClient = new HttpClient();
            Client = httpClient;
            httpClient.BaseAddress = new Uri(URL);

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


        }

        public void RunPayload(int payloadLevel)
        {
            switch (payloadLevel)
            {
                case 1:
                    for (int i = 1; i < 101; i++)
                    {
                        HttpResponseMessage response = Client.GetAsync(_url + "SmallPayload").Result;

                        Console.WriteLine($"Sending REST Request: {i}");
                        if (response != null)
                        {
                            Console.WriteLine($"Received REST Response: {i}");
                        }
                    }
                    break;
                case 2:
                    for (int i = 1; i < 101; i++)
                    {
                        HttpResponseMessage response = Client.GetAsync(_url + "MediumPayload").Result;

                        Console.WriteLine($"Sending REST Request: {i}");
                        if (response != null)
                        {
                            Console.WriteLine($"Received REST Response: {i}");
                        }
                    }
                    break;
                case 3:
                    for (int i = 1; i < 101; i++)
                    {
                        HttpResponseMessage response = Client.GetAsync(_url + "LargePayload").Result;

                        Console.WriteLine($"Sending REST Request: {i}");
                        if (response != null)
                        {
                            Console.WriteLine($"Received REST Response: {i}");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("N/A Level selected.");
                    break;
            }


        }

        public void RunSpecificPayload(int payloadLevel)
        {
            HttpResponseMessage response;
            switch (payloadLevel)
            {
                case 1:
                    Console.WriteLine("Requesting REST Service 100 times.");
                    for (int i = 1; i < 101; i++)
                    {
                        response = Client.GetAsync(_url + "SmallPayload/" + payloadLevel.ToString()).Result;
                    }
                    Console.WriteLine("Requested REST Service 100 times.");
                    break;
                case 2:
                    Console.WriteLine("Requesting REST Service 100 times.");
                    for (int i = 1; i < 101; i++)
                    {
                        response = Client.GetAsync(_url + "MediumPayload/" + payloadLevel.ToString()).Result;
                    }
                    Console.WriteLine("Requested REST Service 100 times.");
                    break;
                case 3:
                    Console.WriteLine("Requesting REST Service 100 times.");
                    for (int i = 1; i < 101; i++)
                    {
                        response = Client.GetAsync(_url + "LargePayload/" + payloadLevel.ToString()).Result;
                    }
                    Console.WriteLine("Requested REST Service 100 times.");
                    break;
                default:
                    Console.WriteLine("N/A Level selected.");
                    break;
            }
        }


    }
}