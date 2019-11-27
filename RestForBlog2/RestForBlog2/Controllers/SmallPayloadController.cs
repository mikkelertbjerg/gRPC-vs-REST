using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestForBlog2.Models;

namespace RestForBlog2.Controllers
{
    public class SmallPayloadController : ApiController
    {
        // Database Connection
        DatabaseConnection db = new DatabaseConnection();
        // GET: api/SmallPayload
        public IEnumerable<SmallPayload> Get()
        {
            List<SmallPayload> smallPayloads = db.GetAllSmallPayloads();
            return smallPayloads;
        }

        // GET: api/SmallPayload/5
        public string Get(int id)
        {
            SmallPayload smallPayload = db.GetSmallPayload(id);
            return smallPayload.ToString();
        }
    }
}
