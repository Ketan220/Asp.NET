using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication35.Models;

namespace WebApplication35.Controllers
{
    public class CalController : Controller
    {
        // GET: Cal
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CalModel cb)
        {
            int n1 = cb.num1;
            int n2 = cb.num2;

            if(n1>n2)
            {
                ViewBag.result = n1 + " is greater";
               
            }
            else if(n2>n1)
            {
                ViewBag.result = n2 + "is greater";
               
            }
            return View();
        }
    }
}