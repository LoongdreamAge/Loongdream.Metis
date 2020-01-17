using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Loongdream.Metis.WebSite.Controllers
{
    public class OtherPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 常规登陆
        /// </summary>
        /// <returns></returns>
        public IActionResult I18support()
        {
            return View();
        }
    }
}