using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication36.Models;

namespace WebApplication36.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        // 1. *********** Display All Item List in Index Page ***********
        public ActionResult Index()
        {
            ViewBag.ItemList = "Cpomputer Shop Item List";
            ItemDBHandler Ihandler=new ItemDBHandler();
            ModelState.Clear();


            return View(Ihandler.GetItemList());
        }

        // 2. *********** Add New Item ***********
        [HttpGet]
        public ActionResult create()
        {
            return View();  
        }
        [HttpPost]
        public ActionResult Create(ItemModel iList)
        {
            if(ModelState.IsValid)
            {
                ItemDBHandler Itemhandler=new ItemDBHandler();

                if(Itemhandler.InsertItem(iList))
                {
                    ViewBag.Message = "Item Added Successfully";
                    ModelState.Clear();

                }
            }
            return View();
        }

        // 3. *********** Update Item Details ***********
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ItemDBHandler ItemHandler = new ItemDBHandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));
        }
        [HttpPost]
        public ActionResult Edit(int id, ItemModel iList)
        {
            try
            {
                ItemDBHandler ItemHandler = new ItemDBHandler();
                ItemHandler.UpdateItem(iList);
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }


        // 4. *********** Delete Item Details ***********
        public ActionResult Delete(int id)
        {
            try
            {
                ItemDBHandler Ihandler = new ItemDBHandler();
                if (Ihandler.DeleteItem(id))
                {
                    ViewBag.AlertMsg = "Item Deleted Successfully";
                }

                return RedirectToAction("Index");
            }
             catch
            {
                return View();
            }
        }

        // 5. *********** Search Items ***********
        public ActionResult Details(int id)
        {
               ItemDBHandler Ihandler=new ItemDBHandler(); 
                return View(Ihandler.GetItemList().Find(ItemModel=>ItemModel.ID == id));    
           
        }


    }
}