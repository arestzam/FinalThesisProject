using MarketStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketStore.Controllers
{


    // This checkout controller will be used to allow users to get registered before going through the check out process for the products in the shopping basket


        // Now I will need to make users get themselves registered before doing any checkout
        [Authorize]

            public class CheckoutController : Controller
            {
        
                    // I will create now an instance of the database that holds all products

                    MarketStoreEntities storeDB = new MarketStoreEntities();


            // I will create one controller action now that will prompt the shopper to enter information


        // GET: Checkout
                public ActionResult ShopperAddressPaymentDetails()
                {
                    return View();
                }



        // This post controller action will validate the user input details after the order has been made

        //POST: Checkout 

        [HttpPost]

                public ActionResult ShopperAddressPaymentDetails(FormCollection values)


                {


                    var order = new Order();
            
                    order.UserShopper = User.Identity.Name;

                    order.OrderDate = DateTime.Now;


            //Saves the order now into the database


                    storeDB.Orders.Add(order);
                    storeDB.SaveChanges();


            // Since the order has been created and saved, it should now be added into the shopping cart

                    var cart = ShoppingCart.GetCart(this.HttpContext);
                    cart.CreateOrder(order);
            

            // Now I will close the controller action

                    return RedirectToAction("Complete", new { transid = order.OrderId });
                        

        }


        //GET:  /

        // Now I will write up another controller action that completes the checkout process after the order is final.
        
           
        public ActionResult CheckoutComplete(int checkoutid)

        {

            // The following checks the validity of the shopper's order. It will check both if there is a match for the order id and for the shopper's name


            bool IsOrderValid = storeDB.Orders.Any  

                (sh => sh.OrderId == checkoutid  && 
                 sh.UserShopper == User.Identity.Name);

            // Checks for the validity of the customer details and if true validates such customer details


            if (!IsOrderValid)

            
                return View(checkoutid);

            

            else
            
                return View("Error");

            

        }

    }
}