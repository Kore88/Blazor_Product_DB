using Microsoft.EntityFrameworkCore;
using Product_DB_Gyak.Model;
using System.Security.Cryptography.X509Certificates;

namespace Product_DB_Gyak.Data
{
    public class MyDBconetext :DbContext
    {
        public MyDBconetext(DbContextOptions<MyDBconetext> options) : base(options) { }
        public DbSet<Product> Products { get; set; } = default;


    }
}
