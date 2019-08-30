using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketStore.Models
{
    public class OrderDetails
    {

     // This class will hold all the details pertaining to the order for the shopper
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int ProductId{get;set;}

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }


        public virtual Product Product { get; set;}
        public virtual Order Order { get; set; }

    }
}