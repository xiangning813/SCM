using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    using Models;
    public class PdskcController : ApiController
    {
        public IHttpActionResult GetSelectUserAll()
        {
            PSSEntities db = new PSSEntities();
            return Json(db.Users);
        }
    }
}
