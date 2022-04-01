using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication26.Models;

namespace WebApplication26.Controllers
{
    public class CalculateController : Controller
    {
        // GET: Calculate
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(CalculateModel u)
        {
            int n1 = u.num1;
            int n2 = u.num2;
            int res=n1+n2;

            ViewBag.result=res;
            return View();
        }
    }
}