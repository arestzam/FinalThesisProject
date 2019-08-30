using System.Collections.Generic;
using System.Data.Entity;

using System.EnterpriseServices;

using System.Linq;
using System.Web.Configuration;
using System.Threading.Tasks;

namespace MarketStore.Models
{


    // How to inherit from the DbContext class? Just install Entity framework by using command "install-package-entityframework" from 
    // Tools > Library Package Manager > Package Manager Console.

    public class MarketStoreEntities : System.Data.Entity.DbContext
    {

            public MarketStoreEntities(): base("MarketStore")


                {


                }



        public DbSet<Product> Products{ get; set; }


        public DbSet<Category> Categories { get; set; }


        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Cart> Carts { get; set; }

        
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }



        

    }
}