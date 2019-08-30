using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.ComponentModel.DataAnnotations;

namespace MarketStore.Models
{
    public partial class Category
    {

        [ScaffoldColumn(false)]

        public int CategoryId { get; set; }

        [Required, StringLength(100), Display (Name = "Name")]
        public string CategoryName { get; set; }
        
        
        [Required, StringLength(100), Display(Name = "Category Description")]
        public string CategoryDescr { get; set; }

        public List<Product> Products { get; set; }       
    }
}