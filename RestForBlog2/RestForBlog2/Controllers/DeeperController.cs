using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestForBlog2.Models;

namespace RestForBlog2.Controllers
{
    public class DeeperController : ApiController
    {
        DatabaseConnection db = new DatabaseConnection();
        // GET: api/Deeper
        public IEnumerable<DeeperPayload> Get()
        {
            List<DeeperPayload> deepCol = db.GetAllDeeperPayloads();
            return deepCol;
        }

        // GET: api/Deeper/5
        public string Get(int id)
        {
            DeeperPayload deep = db.GetDeeperPayload(id);
            return deep.ToString();
        }

      
    }
}
