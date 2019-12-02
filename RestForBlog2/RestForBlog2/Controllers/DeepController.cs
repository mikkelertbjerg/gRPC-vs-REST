using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestForBlog2.Models;

namespace RestForBlog2.Controllers
{
    public class DeepController : ApiController
    {
        DatabaseConnection db = new DatabaseConnection();
        // GET: api/Deep
        public IEnumerable<DeepPayload> Get()
        {
            List<DeepPayload> deepCol = db.GetAllDeepPayloads();
            return deepCol;
        }

        // GET: api/Deep/5
        public string Get(int id)
        {
            DeepPayload deep = db.GetDeepPayload(id);
            return deep.ToString();

        }

    }
}
