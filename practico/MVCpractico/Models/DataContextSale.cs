using System.Data.Entity;

namespace MVCpractico.Models
{
    public class DataContextSale:DbContext
    {
        public DataContextSale():base("DefaultConnection")
        {

        }

    }
}