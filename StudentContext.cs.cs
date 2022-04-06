using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication39.Models
{
    public class StudentContext:DbContext
    {
        public  StudentContext():base("studsDatabse")
        {

        }
        public DbSet<Student> Students { get; set; }    
            
    }
}