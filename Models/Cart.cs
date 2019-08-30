using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace MarketStore.Models
{
    public class Cart
    {
        [Key]


        public int TransactionId { get; set; }
        
        public string CartId { get; set; }

        public int ProductId { get; set; }
        
        public int CategoryId { get; set; }

        public int Count { get; set; }

        public System.DateTime DateCreated { get; set; }

        public virtual Product product { get; set; }


    }
}