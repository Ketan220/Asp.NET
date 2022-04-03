namespace WebApplication29.Models
{
    public class SignupModel
    {
        public string username { get; set; }
        public string gender{ get; set; }

        public bool java { get; set; }  
        public bool dotnet { get; set; }    

        public CityType SelectCityType { get; set; }

        public enum CityType { Nagpur,Delhi,Pune}
     

      
      
    }
}
