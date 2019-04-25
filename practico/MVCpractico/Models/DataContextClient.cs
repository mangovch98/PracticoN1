using System.Data.Entity;

namespace MVCpractico.Models
{
    public class DataContextClient:DbContext
    {
        public DataContextClient():base("DefaultConnection")
        {
    }
    }
}