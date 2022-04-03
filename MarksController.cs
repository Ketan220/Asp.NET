using Microsoft.AspNetCore.Mvc;
using WebApplication27.Models;

namespace WebApplication27.Controllers
{
    public class MarksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index ( MarksModel u)
        {
            int m1 = u.marks1;
            int m2 = u.marks2;
            int m3 = u.marks3;

            int total = m1 + m2 + m3;

            float per = (float)(total / 300.0f) * 100.0f;

            string res=null;
            if(per>75)
            {
                 res = "grade A";
            }
            else if(per>50 && per<75)
            {
                 res = "Grade B";
            }

            ViewBag.total = total;
            ViewBag.per = per;
            ViewBag.res = res;

            return View();
        }
        
    }
}
