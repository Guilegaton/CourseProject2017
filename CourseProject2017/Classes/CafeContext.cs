using System.Data.Entity;

namespace CourseProject2017.Classes
{
    class CafeContext : DbContext
    {
        public CafeContext() :
            base("ChefsDB")
        { }

        public DbSet<Chef> Chefs { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Reception> Receptions { get; set; }
        public DbSet<Chek> Cheks { get; set; }
    }
}
