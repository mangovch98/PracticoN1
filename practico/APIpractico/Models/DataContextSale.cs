using System.Data.Entity;

namespace APIpractico.Models
{
    public class DataContextSale:DbContext
    {
        public DataContextSale():base("DefaultConnection")
        {

        }
    }
}