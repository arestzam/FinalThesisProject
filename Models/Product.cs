using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace MarketStore.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]

            public int ProductId { get; set; }

        [DisplayName ("Supplier")]

            public int SupplierId { get; set; }


        [DisplayName ("Category")]
            public int CategoryId { get; set; }



        [Required(ErrorMessage = "A Product Name is Required")]
        [StringLength(100)]
            public string ProductName { get; set; }


        [Required(ErrorMessage = "Price is Required")]
        [Range(0.01, 100.00, ErrorMessage = "Price must be between this range")]

           public decimal Price { get; set; }


        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]

           public string ProductDescr { get; set; }

       
       [DisplayName("Product Pic")]
       [StringLength(1024)]


        public string ProductPic { get; set; }

        
        public string Category{ get; set; }

        public string Supplier { get; set; }


        public virtual List<OrderDetails> OrderDetails { get; set; } 



    }
}


