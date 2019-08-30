using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketStore.ViewModels
{


    // This class will confirm that the product has been removed from the shopping cart


    public class ShoppingCartRemoveViewModel
    {
        // I will define four different properties for this class

          
          public string ConfirmedMsg{ get; set; }
        
         // The property to track the items in the shopping cart
          public int ShopCartCount { get; set; }

          // The property to show the total value of items
          public decimal ShopCartTotal { get; set; }

         
          public  int ProdCount { get; set; }
        


        // The property to remove the item from the shopping basket
    
          public int RemoveItemId { get; set; }


          



    }
}