using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestForBlog2.Models;

namespace RestForBlog2.Controllers
{
    public class MediumPayloadController : ApiController
    {
        // Database Connection
        DatabaseConnection db = new DatabaseConnection();
        // GET: api/MediumPayload
        public IEnumerable<MediumPayload> Get()
        {
            List<MediumPayload> mediumPayloads = db.GetAllMediumPayloads();
            return mediumPayloads;
        }

        // GET: api/MediumPayload/5
        public string Get(int id)
        {
            MediumPayload mediumPayload = db.GetMediumPayload(id);
            return mediumPayload.ToString();
        }

    }
}
