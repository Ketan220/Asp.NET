using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication37.Models;

namespace WebApplication37.Controllers
{
    public class ProductController : Controller
    {

        // GET: Item
        // 1. *********** Display All Item List in Index Page ***********
        public ActionResult Index()
        {
            ViewBag.ItemList = "Cpomputer Shop Item List";
           ProductDBHandler Phandler = new ProductDBHandler();

            ModelState.Clear();


            return View(Phandler.GetItemList());
        }

        // 2. *********** Add New Item ***********
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductModel iList)
        {
            if (ModelState.IsValid)
            {
                ProductDBHandler Phandler = new ProductDBHandler();

                if (Phandler.InsertItem(iList))
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
            ProductDBHandler Phandler = new ProductDBHandler();
            return View(Phandler.GetItemList().Find(productModel =>productModel.ID == id));
        }
        [HttpPost]
        public ActionResult Edit(int id, ProductModel iList)
        {
            try
            {
                ProductDBHandler Phandler = new ProductDBHandler();
                Phandler.UpdateItem(iList);
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }


        // 4. *********** Delete Item Details ***********
        public ActionResult Delete(int id)
        {
            try
            {
                ProductDBHandler Phandler = new ProductDBHandler();
                if (Phandler.DeleteItem(id))
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
            ProductDBHandler Phandler = new ProductDBHandler();
            return View(Phandler.GetItemList().Find(ProductModel => ProductModel.ID == id));

        }
    }
}