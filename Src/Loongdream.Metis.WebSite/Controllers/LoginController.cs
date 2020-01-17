using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Loongdream.Metis.WebSite.Controllers
{
    public class LoginController : Controller
    {
        /// <summary>
        /// 常规登陆
        /// </summary>
        /// <returns></returns>
        public IActionResult Default()
        {
            return View();
        }
        /// <summary>
        /// Ldap登录
        /// </summary>
        /// <returns></returns>
        public IActionResult LDAP()
        {
            ViewData["Title"] = "域账户登录";
            return View();
        }
    }
}