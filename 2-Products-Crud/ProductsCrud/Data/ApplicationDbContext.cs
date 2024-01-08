using Microsoft.EntityFrameworkCore;
using ProductsCrud.model;

namespace ProductsCrud.Data{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Product> producto {get; set;}
        public DbSet<ProductCategory> productCategory {get;set;}
    }
    
}