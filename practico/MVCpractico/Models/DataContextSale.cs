using System.Data.Entity;

namespace MVCpractico.Models
{
    public class DataContextSale:DbContext
    {
        public DataContextSale():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCpractico.Models.Sale> Sales { get; set; }
    }
}