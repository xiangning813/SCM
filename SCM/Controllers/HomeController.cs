using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCM.Controllers
{
    using System.Net.Http;
    public class HomeController : Controller
    {
        string url = "https://localhost:44316/api/home";
        // GET: Home

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Single(string UserLoginName, string UserLoginPwd)
        {
            HttpClient client = new HttpClient();
            Dictionary<string, string> dics = new Dictionary<string, string>()
            {
                      {"UserLoginName",UserLoginName},
                      {"UserLoginPwd",UserLoginPwd}
            };
            FormUrlEncodedContent fc = new FormUrlEncodedContent(dics);
            var ct = client.PostAsync(url, fc)
                .Result
                .Content
               .ReadAsStringAsync()
               .Result;
            if (ct != null)
            {
                //存储对象
                Session["u"] = new
                {
                    Uname = ct.Split(',')[0],
                    Upwd = ct.Split(',')[1]
                };
                return RedirectToAction("main", "Home");
            }
            else
                return Json("请检查账号或密码！");
        }
        public ActionResult main()
        {
            return View();
        }
    }
}