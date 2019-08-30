using MarketStore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;



namespace MarketStore.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

            //I create an instance of the database now

        MarketStoreEntities storeDB = new MarketStoreEntities();


         // RetrieveDemoEntities Retrieve = new RetrieveDemoEntities();



        public ActionResult Index()
        
        {


            var products = storeDB.Products.ToList();


                return View(products);


        }
      
        
    

        //This method will return all products in descending order with order details
        private List<Product> AllOrderProducts(Product product)

        {



            return storeDB.Products


                .OrderByDescending(w => w.OrderDetails.Count())
                
                .ToList();


        }


        
    }
}