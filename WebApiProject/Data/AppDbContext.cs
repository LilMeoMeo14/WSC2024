using Microsoft.EntityFrameworkCore;
using WebApiProject.Models;

namespace WebApiProject.Data
{
    public class AppDbContext : DbContext
    {
        // constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 
        
        //Entity set mapping
        //Ánh xạ tới các bảng trong DB
        public DbSet<Customers> Customers=>Set<Customers>();
        public DbSet<Products> Products=>Set<Products>();
        public DbSet<Orders> Orders=>Set<Orders>();
        public DbSet<OrderItems> OrderItems=>Set<OrderItems>();

        // dung cho test 
        

    }
}
