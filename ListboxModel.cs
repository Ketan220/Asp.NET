using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace WebApplication31.Models
{
    public class ListboxModel
    {
        public int[] SelectedTeaIds { get; set; }
        public IEnumerable<SelectListItem> TeaList { get; set; }

    }
}
