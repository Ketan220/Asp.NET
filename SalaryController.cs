using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication35.Models;

namespace WebApplication35.Controllers
{
    public class SalaryController : Controller
    {
        // GET: Salary
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(SalaryModel sm)
        {
            ViewBag.empno = sm.empno;
            ViewBag.empname=sm.empname;

            float bs1 = sm.bs;
            ViewBag.bs1 = bs1;  
            float hra = bs1 * 0.65f;
            float da = bs1 * 0.25f;
            float ta = bs1 * 0.45f;

            float total=hra + da + ta;

            ViewBag.hra=hra;
            ViewBag.da=da;
            ViewBag.ta=ta;
            ViewBag.total=total;    

            return View();  

        }
    }
}