//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebEcommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImgProduct
    {
        public int ImgId { get; set; }
        public string ImgProducts { get; set; }
        public Nullable<int> ProductsId { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
