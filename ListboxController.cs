using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication31.Models;



namespace WebApplication31.Controllers
{
    public class ListboxController : Controller
    {

        public ActionResult Index()
        {
            var model = new ListboxModel
            {
                SelectedTeaIds = new[] { 1 },
                TeaList = GetAllTeaTypes()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ListboxModel model)
        {
            model.TeaList = GetAllTeaTypes();
            if (model.SelectedTeaIds != null)
            {
                List<SelectListItem> selectedItems = model.TeaList.Where(p => model.SelectedTeaIds.Contains(int.Parse(p.Value))).ToList();
                foreach (var Tea in selectedItems)
                {
                    Tea.Selected = true;
                    ViewBag.Message += Tea.Text + " | ";
                }
            }
            return View(model);
        }

        public List<SelectListItem> GetAllTeaTypes()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "General Tea", Value = "1" });
            items.Add(new SelectListItem { Text = "Coffee", Value = "2" });
            items.Add(new SelectListItem { Text = "Green Tea", Value = "3" });
            items.Add(new SelectListItem { Text = "Black Tea", Value = "4" });
            return items;
        }
    }
}

