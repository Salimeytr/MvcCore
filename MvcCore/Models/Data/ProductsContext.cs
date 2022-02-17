using Microsoft.EntityFrameworkCore;
using MvcCore.Models.Classes;

namespace MvcCore.Models.Data
{
    public class ProductContext : DbContext

    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<Categories> Categories { get; set; }
        


    }

    
   

}
