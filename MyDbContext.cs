using Microsoft.EntityFrameworkCore;

namespace LinQDemo
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=DESKTOP-PBUC8F9\SQLEXPRESS;Initial Catalog=AdventureWorksDW2022;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<FactInternetSales> FactInternetSales { get; set; }
        public DbSet<DimProduct> DimProduct { get; set; }
    }
}
