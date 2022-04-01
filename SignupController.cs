using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication26.Models;

namespace WebApplication26.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Index(SignupModel u)
        {
            ViewBag.username = u.username;
            ViewBag.password = u.password;  

            return View();
        }
    }
}