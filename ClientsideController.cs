using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication34.Models;

namespace WebApplication34.Controllers
{
    public class ClientsideController : Controller
    {
        // GET: Clientside
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult abc(Clientside cm)
        {
            if(ModelState.IsValid)
            {
                ViewBag.name = cm.Name;
                ViewBag.email = cm.Email;
                ViewBag.age = cm.Age;
                ViewBag.hiredate = cm.HireDate;
                ViewBag.pno = cm.Pno;
                return View("Index");
            }
            else
            {
                ViewBag.name = "No Data";
                ViewBag.email = "No Data";
                ViewBag.age = "No Data";
                ViewBag.pno = "No Data";
                return View("Index");
            }
        }
    }
}