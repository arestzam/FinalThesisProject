
using System.Collections.Generic;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MarketStore.Models
{

    
    [Bind(Exclude = "OrderId")]


    // The order class holds all details about the order being made from the shopper
    public class Order
    {
    
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        
        [ScaffoldColumn(false)]
        public string UserShopper { get; set; }


        
        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        [StringLength(160)]

        public string FirstName { get; set; }

        

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("LastName")]
        [StringLength(160)]

        public string LastName { get; set; }

        

        [Required(ErrorMessage = "Address is required")]

        [DisplayName("Address")]
        [StringLength(40)]

        public string Address { get; set; }



        [Required(ErrorMessage = "City")]
        [StringLength(40)]
        public string City { get; set; }


        [Required(ErrorMessage = "Country is required")]
        [StringLength(20)]

        [ScaffoldColumn(false)]
        public string Country { get; set; }

         

        [Required(ErrorMessage = "Phone is required")]
        [StringLength(24)]
        public string Phone { get; set; }

        

        public string Email { get; set; }

        [Required(ErrorMessage = "Email address required")]
        [DisplayName("Email Address")]

        
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]

        
        [DataType(DataType.EmailAddress)]

        public string email { get; set; }

     
        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        public System.DateTime OrderDate { get; set; }


        // I will need to create another class that will store details for the particular order
        public List<OrderDetails> OrderDetails { get; set; }




    }
}