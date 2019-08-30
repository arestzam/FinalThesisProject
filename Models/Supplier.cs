using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MarketStore.Models
{

    // This will be the junction table 
    public class Supplier
    {
        public int SupplierId { get; set; }

        
        public string SupplierName { get; set; }
    }
}