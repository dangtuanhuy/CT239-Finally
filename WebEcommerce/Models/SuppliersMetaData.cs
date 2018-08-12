using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebEcommerce.Models
{
    [MetadataTypeAttribute(typeof(Supplier.SuppliersMetaData))]
    public partial class Supplier
    {
        internal sealed class SuppliersMetaData
        {
            [Display(Name = "Supplier Id")]
            public int SupplierId { get; set; }

            [Display(Name = "Company")]
            public string CompanyName { get; set; }

            [Display(Name = "Member")]
            public string ContactName { get; set; }


            [Display(Name = "Contact Title")]
            public string ContactTitle { get; set; }

            [Display(Name = "Address")]
            public string Address { get; set; }

            [Display(Name = "Phone")]
            public string Phone { get; set; }

            [Display(Name = "Fax")]
            public string Fax { get; set; }

            [Display(Name = "Category Id")]
            public string HomePage { get; set; }
        }
    }

}