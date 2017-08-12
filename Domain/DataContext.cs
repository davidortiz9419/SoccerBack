using System.Data.Entity;

namespace Domain
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public DbSet<League> Leagues { get; set; }
    }
}
