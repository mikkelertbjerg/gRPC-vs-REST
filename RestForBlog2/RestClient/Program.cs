using RestForBlog2.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RestClient
{
    class Program
    {

        static void Main(string[] args)
        {
            string URL = "https://sub.domain.com/objects.json";
            string urlParameters = "?api_key=123";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(urlParameters).Result;

           
        }
    }
}
