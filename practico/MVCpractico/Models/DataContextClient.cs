using System.Data.Entity;

namespace MVCpractico.Models
{
    public class DataContextClient:DbContext
    {
        public DataContextClient():base("DefaultConnection")
        {
    }

        public System.Data.Entity.DbSet<MVCpractico.Models.Client> Clients { get; set; }
    }
}