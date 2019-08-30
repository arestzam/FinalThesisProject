using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MarketStore.Models;
using MarketStore.ViewModels;


namespace MarketStore.Controllers
{

    // This purpose of this ShoppingCartController is threefold   a) Add the products in the cart,  b) Remove products from the cart and c) View products inside the cart.
    public class ShoppingCartController : Controller
    {


        MarketStoreEntities storeDB = new MarketStoreEntities();


        // Now I will fetch the shopping cart of the shopper
        // GET: ShoppingCart


        public ActionResult Index()
        {

            var cart = ShoppingCart.GetCart(this.HttpContext);


            // Now set up the ViewModel as this will represent only data that I want to use

            var viewModel = ShoppingCart.GetCart(this.HttpContext);

            {


                var CartItems = cart.GetCartItems();
                var CartTotal = cart.GetTotal();

            };


                //Return the view

                return View(viewModel);

        }

        

        // GET: Store / AddToCart


        public ActionResult AddToCart(int id)


        {

            //I will now write up an action to retrieve the product from the stored database

            var addedProduct = storeDB.Products.Single(product => product.ProductId == id);


            //Next step is to add the product into the shopping cart.


            var cart = ShoppingCart.GetCart(this.HttpContext);


            // Now I will call up the method to add up the product into the cart

            cart.AddToCart(addedProduct);


            //Final step is to get the user back to the product order's page to continue with shopping

            return RedirectToAction("Index");

        }


  
    // At this point I will write up a controller action to remove all products from shopping cart by calling the RemoveFromCart method

                [HttpPost]


                public ActionResult RemoveFromCart(int transid)

                {

            // Now I will call the shopping cart from which the item will be removed

        
                        var cart = ShoppingCart.GetCart(HttpContext);


            // Fetch and store the product to be removed from the database products list by matching the temporary transaction id created for this remove action. 

                        string productName = storeDB.Carts.Single(basketitem => basketitem.TransactionId == transid).product.ProductName;


            //  Now the final step is to remove the product from the shopping basket but keep count of all items in the basket

                        int prodCount = cart.RemoveFromCart(transid);


            // Display the confirmation notification message

            
                var notification = new ShoppingCartRemoveViewModel

                    {

                                ConfirmedMsg = Server.HtmlEncode(productName) +
                                        "has been removed from the shopping cart",
                            
                                ShopCartTotal = cart.GetTotal(),

                                ShopCartCount = cart.GetCount(),

                                ProdCount = prodCount,

                                RemoveItemId = transid


                    };


                    return Json(notification);


                }


            // GET:  Shopping/Cart/CartSummary


            [ChildActionOnly]
            public ActionResult CartSummary()


            {

                var cart = ShoppingCart.GetCart(this.HttpContext);


                ViewData["CartCount"] = cart.GetCount();


                return PartialView("CartSummary");

                
            }
                       
        }
    }
