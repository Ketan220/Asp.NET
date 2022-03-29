using Microsoft.AspNetCore.Mvc;
using WebApplication23.Models;

namespace WebApplication23.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";

            List<ItemList> ilist=new List<ItemList>();

            {
                new ItemList { Id = 1, Name = "iphone", Category = "phone", Price = 89000 };
                new ItemList { Id = 2, Name = "Harddisk", Category = "computer", Price = 2999 };
                new ItemList { Id = 3, Name = "Mouse", Category = "Computer", Price = 120 };
                new ItemList { Id = 4, Name = "Samsung Note3", Category = "Mobile", Price = 9348 };
            };



            return View(ilist);
        }
    }
}
