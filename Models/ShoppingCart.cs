using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketStore.Models
{
    public partial class ShoppingCart
    {



        /* The ShoppingCart will be responsible for controlling all items added to cart for the shopper as well as adding or removing items from the cart.
         All shoppers may do their purchases without registering but there will be a temporary ID assigned to them for the transaction in progress. This ID will be stored inside the
         Session class */


        // The ShoppingClass has a bunch of methods described below

        MarketStoreEntities storeDB = new MarketStoreEntities();


        public string ShoppingCartId { get; set; }


        public const string CartSessionKey = "CartId";

        public static ShoppingCart GetCart(HttpContextBase context)

        {

            var cart = new ShoppingCart();




           //  cart.ShoppingCartId = GetCartId(context);




            return cart;


        }


        //Here follow some Helper method to simplify shopping cart calls

        public static ShoppingCart GetCart(Controller controller)

        {

            return GetCart(controller.HttpContext);

        }


        // This method will add products purchased into the cart of the shopper


        public void AddToCart(Product product)

        {

            // Retrieves the product from the database


                    ShoppingCartId = GetCartId();


            //Get the matching cart and the matching associated product inside the cart 

            
            var cartItem = storeDB.Carts.SingleOrDefault

           (f => f.CartId == ShoppingCartId && f.ProductId == product.ProductId);


            // Now I will need to check if the shopping cart is empty otherwise I need create a new one by calling the Cart class

            if (cartItem == null)

            {

                // Now I will create a new cart item for first time as no cart item does exist

                cartItem = new Cart

                {

                    ProductId = product.ProductId,
                    CartId = ShoppingCartId,
                    Count = 1,
                    DateCreated = DateTime.Now

                };

                //Now I will add the product into the shopping cart

                storeDB.Carts.Add(cartItem);

            }

            else

            {
                // Now since the item not existent into the cart, just increment the counter 


                cartItem.Count++;

            }

            //Now save all such changes

            storeDB.SaveChanges();

        }



        // Now I will write up a method to remove products from the cart and keep track of such items


        public int RemoveFromCart(int transid)

        {

            //Now fetch the shopping cart and check if there is a match with the user's id

            var cartItem = storeDB.Carts.Single(cart => cart.CartId == ShoppingCartId && cart.TransactionId == transid);

            // Now declare a local variable as a counter for the product items inside the shopping basket 

            int basketitemCount = 0;


            //Now first just make a check if the shopping cart is empty so as to remove the item from the shopping basket


            if (cartItem != null)

            {

                if (cartItem.Count > 1)

                {

                    // Decrease the counter of items in the shopping basket
                    cartItem.Count--;

                    // Link the local counter variable with the general shopping cart counter
                    basketitemCount = cartItem.Count;

                }

                else

                {

                    // Now remove the item from the database of products

                    storeDB.Carts.Remove(cartItem);

                }


                //Save all such changes and update the database of all products

                storeDB.SaveChanges();

            }


            // Now return the product counter of all the items contained into the basket after removal 

            return basketitemCount;

        }
        //Now I will write up another method to dispose/empty the shopping cart 

        public void EmptyCart()

        {

            var cartItems = storeDB.Carts.Where(cart => cart.CartId == ShoppingCartId);

            foreach (var basketcartItem in cartItems)
            {

                storeDB.Carts.Remove(basketcartItem);

            }

            // Save changes

            storeDB.SaveChanges();
        }



        // Now I will write up another method GetCartItems here to get all items in the shopping cart 


        public List<Cart> GetCartItems()

        {



            return storeDB.Carts.Where(cart => cart.CartId == ShoppingCartId).ToList();

        }



        //Here follows another method that counts all products in the shopping cart 

        public int GetCount()

        {

            // Now it will count every single item in the shopping cart and return the total number of such items by adding them up


            int count = (from cartItems in storeDB.Carts
                         where cartItems.CartId == ShoppingCartId
                         select (int)cartItems.Count).Sum();


            // Otherwise it will return null 0 as the total number of all items if there is no match for the cart items id and the shopping basket id

            return count = 0;

        }



        //This method will calculate the total value of all items in the shopping basket by multiplying the respective product price by the quantity and then
        // sum up all such values to return the total cart value

        public decimal GetTotal()

        {


            decimal total = (from cartItems in storeDB.Carts
                             where cartItems.CartId == ShoppingCartId
                             select (int)cartItems.Count * cartItems.product.Price).Sum();


            return total;


        }


        //This method will take the data details from the cart and make an order for the shopper just before the check out process

        public int CreateOrder(Order order)

        {

            decimal orderTotal = 0;

            var CartItems = GetCartItems();


            // Now go through all products contained into the shopping cart and add up all order details for each product to create the final order 


            foreach (var cartitem in CartItems)

            {
                var orderDetail = new OrderDetails

                {
                    ProductId = cartitem.ProductId,
                    OrderId = order.OrderId,
                    UnitPrice = cartitem.product.Price,
                    Quantity = cartitem.Count

                };


                // Now increment the order total by adding up all the products values from the shopping basket 

                orderTotal += (cartitem.Count * cartitem.product.Price);


                // Now save the order details into the matching order list for the shopper

                storeDB.OrderDetails.Add(orderDetail);

            }

            // Now save the shopper's order's total of the shopping cart into the local variable

            order.Total = orderTotal;


            // Next step is to save and update the order changes  

            storeDB.SaveChanges();

            // Here is the step is to clear up / empty the shopping cart after such an order has been processed

            EmptyCart();


            // Final part of this method is to return the orderId after this order has taken place and confirmed

            return order.OrderId;


        }

    


        public string GetCartId()
        


        {

            if (HttpContext.Current.Session[CartSessionKey] == null)
            {



                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))

                {


                    HttpContext.Current.Session[CartSessionKey] = HttpContext.Current.User.Identity.Name;

                }

                else

                {


                    // Just create a new GUID with the System.Guid class

                    Guid temporaryCartId = Guid.NewGuid();

                    HttpContext.Current.Session[CartSessionKey] = temporaryCartId.ToString();


                }

            }
                        return HttpContext.Current.Session[CartSessionKey].ToString();

            
            
        }






    // Finally I will write up this method that associates the shopping cart details with the particular shopper who made the purchase



           
                public void MigrateCart(string shoppername)

                {

                var shopCart = storeDB.Carts.Where(w => w.CartId == ShoppingCartId);

           
                foreach(Cart item in shopCart)

                    {

                        item.CartId = shoppername;

                    }


                storeDB.SaveChanges();

        }        
    }

}
    



        