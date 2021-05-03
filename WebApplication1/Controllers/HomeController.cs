using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    using Models;
    public class HomeController : ApiController
    {
        PSSEntities DB = new PSSEntities();
        public void options() { }

        public IHttpActionResult Post(Users u)
        {
            string str = null;

            //查询对象是否为空
            var obj = DB.Users.Where(U => U.UserLoginName == u.UserLoginName && U.UserLoginPwd == u.UserLoginPwd);

            if (obj != null)
                str = u.UserLoginName + "," + u.UserLoginPwd;

            return Json(str);
        }



    }
}
