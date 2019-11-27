using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestForBlog2.Models;

namespace RestForBlog2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        DatabaseConnection db = new DatabaseConnection();
        public IEnumerable<ObjectModel> Get()
        {
            List<ObjectModel> a = db.GetAllObjectModels();
            return a;
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            var a = db.GetObject(id);
            return a.StrValue;
        }
    }
}
