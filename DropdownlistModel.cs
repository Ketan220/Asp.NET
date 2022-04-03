namespace WebApplication30.Models
{
    public enum TeaType
    {
        Tea, Coffee, GreenTea, BlackTea
    }

    public class DropdownlistModel
    {
        public TeaType SelectTeaType { get; set; }
    }

}
