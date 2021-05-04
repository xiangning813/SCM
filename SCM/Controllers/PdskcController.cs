using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCM.Controllers
{
    public class PdskcController : Controller
    {
        // GET: Pdskc
        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult Devolves()
        {
            return PartialView();
        }
        public ActionResult Split()
        {
            return PartialView();
        }
        public ActionResult Losts()
        {
            return PartialView();
        }
        public ActionResult PayOff()
        {
            return PartialView();
        }
        public ActionResult Assemble()
        {
            return PartialView();
        }
        public ActionResult CheckDepot()
        {
            return PartialView();
        }
        public ActionResult Stream()
        {
            return PartialView();
        }
    }
}