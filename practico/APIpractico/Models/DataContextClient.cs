using System.Data.Entity;

namespace APIpractico.Models
{
    public class DataContextClient:DbContext
    {
        public DataContextClient():base("DefaultConnection")
        {
    }
    }
}