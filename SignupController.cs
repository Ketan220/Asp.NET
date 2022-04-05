using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication37.Models;

namespace WebApplication37.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        public ActionResult Index()
        {
            return View();
        }
        // 2. *********** Add New Item ***********
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(SignupModel iList)
        {
            // try
            //{
            if (ModelState.IsValid)
            {
                SignupDBHandler ItemHandler = new SignupDBHandler();
                if (ItemHandler.InsertItem(iList))
                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();
                }
            }
            return View();
            /* }
             catch { return View();  }*/
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(SignupModel iList)
        {
            try
            {
            if (ModelState.IsValid)
            {

                SignupDBHandler ItemHandler = new SignupDBHandler();
                Boolean b = ItemHandler.GetItemList(iList);
                    if(b==true)
                    {
                        Response.Redirect("https://localhost:44384/Product");
                    }
                    else
                    {
                        ViewBag.msg = "Invalid username and password,try again";
                    }
             
                   


            }
                return View();
            }
             catch
            {
                
                
                return View();  
            }
        }

        public ActionResult Details(int id)
        {
            SignupDBHandler ItemHandler = new SignupDBHandler();
            return View();
        }

    }
}