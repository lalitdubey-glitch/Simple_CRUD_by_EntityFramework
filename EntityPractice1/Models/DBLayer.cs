using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityPractice1.Models
{
    public class DBLayer:DbContext
    {
        public DBLayer():base("ConStr") { }
        public DbSet<StudentModel> Students { get; set; }
    }
}