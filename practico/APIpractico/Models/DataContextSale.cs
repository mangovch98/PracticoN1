using System.Data.Entity;

namespace APIpractico.Models
{
    public class DataContextSale:DbContext
    {
        public DataContextSale():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIpractico.Models.Sale> Sales { get; set; }
    }
}