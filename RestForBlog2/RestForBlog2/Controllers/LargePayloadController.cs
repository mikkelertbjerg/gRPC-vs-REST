using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestForBlog2.Models;

namespace RestForBlog2.Controllers
{
    public class LargePayloadController : ApiController
    {
        DatabaseConnection db = new DatabaseConnection();
        // GET: api/LargePayload
        public IEnumerable<LargePayload> Get()
        {
            List<LargePayload> largePayloads = db.GetAllLargePayloads();
            return largePayloads;
        }

        // GET: api/LargePayload/5
        public string Get(int id)
        {
            LargePayload largePayload = db.GetLargePayload(id);
            return largePayload.ToString();
        }
    }
}
