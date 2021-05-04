using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCM.Controllers
{
    public class BasicController : Controller
    {
        // GET: Basic
        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult customer()
        {
            return PartialView();
        }
        public ActionResult product()
        {
            return PartialView();
        }
        public ActionResult store()
        {
            return PartialView();
        }
        public ActionResult supplier()
        {
            return PartialView();
        }
        public ActionResult type()
        {
            return PartialView();
        }
        public ActionResult typeadd()
        {
            return PartialView();
        }
    }
}