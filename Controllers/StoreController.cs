using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketStore.Models;


namespace MarketStore.Controllers
{
    public class StoreController : Controller
    {


        // Let's create an instance of the MarketStoreEntities class that holds all properties of the database 

        MarketStoreEntities storeDB = new MarketStoreEntities();



        //This controller action will add up the categories into a list
        // GET: Store


        public ActionResult Index()
        {

            var categories = storeDB.Categories.ToList();

            return View(categories);
        }


        //
        // GET:  /Store/Browse
        //This action will retrieve the category and the products included into this category from the database of products
            
        public ActionResult Browse(string category)

        {

            // Retrieves from the database the category and the products within this. I need to link the category name with the product name for this to happen.


                        var catModel = storeDB.Categories.Include("Products").Single(k => k.CategoryName == category);
                      

                        return View(catModel);

        }



        // GET:  /Store/Details
        // This controller action queries the product by id and then returns it to the view

         public ActionResult Details(int id)

        {
            
        
            var product = storeDB.Products.Find(id);

                return View(product);

        }


        [ChildActionOnly]
        //The ChildActionOnly atribute ensures that the action method will be used only as a child method from inside the view so there will be a partial view return for this action

        //GET:  /Store/Categories

        // This will pop out the list of all categories for the products contained in the market store supermarket



        public ActionResult CategoryList()

        {

            var categories = storeDB.Categories.ToList();

            return PartialView(categories);

        }

    }

}




       
    
