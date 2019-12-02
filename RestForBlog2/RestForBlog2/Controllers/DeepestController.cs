using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestForBlog2.Models;

namespace RestForBlog2.Controllers
{
    public class DeepestController : ApiController
    {
        DatabaseConnection db = new DatabaseConnection();
        // GET: api/Deepest
        public IEnumerable<DeepestPayload> Get()
        {
            List<DeepestPayload> deepCol = db.GetAllDeepestPayloads();
            return deepCol;
        }

        // GET: api/Deepest/5
        public string Get(int id)
        {
            return db.GetDeepestPayload(id).ToString();
        }
        
    }
}
