using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebEcommerce.Models
{
    [MetadataTypeAttribute(typeof(Product.ProductMetaData))]
    public partial class Product
    {
        internal sealed class ProductMetaData
        {
            [Display(Name = "Products ID")]
            public int ProductId { get; set; }

            [Display(Name = "Products Name")]
            public string ProductName { get; set; }

            [Display(Name = "Products Details")]
            public string ProductDetails { get; set; }

            [Display(Name = "Status")]
            public Nullable<bool> ProductStatus { get; set; }

            [Display(Name = "Img")]
            public string ProductImg { get; set; }

            [Display(Name = "Update")]
            public Nullable<System.DateTime> ProductUpdate { get; set; }

            [Display(Name = "Qty")]
            public Nullable<int> ProductQty { get; set; }

            [Display(Name = "Price")]
            public Nullable<decimal> ProductSold { get; set; }

            [Display(Name = "Old Price")]
            public Nullable<decimal> ProductsOldPrice { get; set; }

       
            public Nullable<int> SupplierId { get; set; }

            
            public Nullable<int> CategoryId { get; set; }
        }
    }
    
}