using System.Data.Entity;

namespace APIpractico.Models
{
    public class DataContextClient:DbContext
    {
        public DataContextClient():base("DefaultConnection")
        {
    }

        public System.Data.Entity.DbSet<APIpractico.Models.Client> Clients { get; set; }
    }
}