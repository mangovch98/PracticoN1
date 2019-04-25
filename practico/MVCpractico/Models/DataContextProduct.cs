using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCpractico.Models
{
    public class DataContextProduct:DbContext
    {
        public DataContextProduct():base("DefaultConnection")
        {

        }

    }
}