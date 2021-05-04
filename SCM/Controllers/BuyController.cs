using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace SCM.Controllers
{
    public class BuyController : Controller
    {
        
        // GET: Buy
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Depot(int SIDID,string PPName,string UsersName,int SIDData)
        {
            return View();
        }
    }
}