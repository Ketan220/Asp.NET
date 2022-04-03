using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace WebApplication33.Models
{
    public class ClientsideModel
    {
        [Required(ErrorMessage ="Name is Required")]
        [StringLength(10, MinimumLength = 3)]
        public string Name { get; set; }
     
    }
}
