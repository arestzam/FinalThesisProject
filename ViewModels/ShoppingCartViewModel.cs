using MarketStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketStore.ViewModels
{
    // The purpose of creating ViewModel is to create strongly typed classes to control the flow of information passed needed by the view templates. Then the controller
    //classes will fill up particular only data to use them in the view templates when requested

    // Here is the ShoppingCartViewModel class which contains the following properties
    public class ShoppingCartViewModel
    {


        //This will store all the items in the list 

        public List<Cart> CartItems { get; set; }



        //And this will store the total added price for all items in the shopping cart
        public decimal CartTotal { get; set; }

    }
}