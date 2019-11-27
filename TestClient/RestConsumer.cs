using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TestClient
{
    public class RestConsumer
    {
        private string _url = "http://localhost:60264/api/values";

        public string URL
        {
            get => _url;
            set => _url = value;
        }


        public void Initialize()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(URL);

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            for (int i = 1; i < 101; i++)
            {
                HttpResponseMessage response = httpClient.GetAsync(_url).Result;
                
                Console.WriteLine("Sending REST Request: " + i);
                if (response != null)
                {
                    Console.WriteLine("Received REST Response: " + response.Content.ReadAsStringAsync().Result);
                }
            }
        }


    }
}