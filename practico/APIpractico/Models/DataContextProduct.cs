using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APIpractico.Models
{
    public class DataContextProduct:DbContext
    {
        public DataContextProduct():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIpractico.Models.Product> Products { get; set; }
    }
}