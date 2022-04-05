using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication37.Models
{
    public class SignupModel
    {
        public int userid { get; set; }
        public String uname { get; set; }
        public String upass { set; get; }
        public String course { set; get; }
        public String city { set; get; }
    }
}