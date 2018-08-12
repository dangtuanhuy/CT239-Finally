using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebEcommerce.Models
{
    [MetadataTypeAttribute(typeof(Category.CategoriesMetaData))]
    public partial class Category
    {
        internal sealed class CategoriesMetaData
        {
            [Display(Name = "Category Id")]
            public int CategoryId { get; set; }
            [Display(Name = "Category Name")]
            public string CategoryName { get; set; }
            [Display(Name = "Description")]
            public string CategoryDetails { get; set; }
        }
    }
   
}