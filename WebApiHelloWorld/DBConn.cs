using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApiHelloWorld
{
    public class DBConn:DbContext
    {
        public DBConn():base("name=DefaultConnection")
        {

        }

        public DbSet<books> dbbooks { get; set; }
        
    }

}