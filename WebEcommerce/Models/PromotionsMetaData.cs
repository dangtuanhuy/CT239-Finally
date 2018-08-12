using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebEcommerce.Models
{
    [MetadataTypeAttribute(typeof(Promotion.PromotionsMetaData))]
    public partial class Promotion
    {
        internal sealed class PromotionsMetaData
        {
            [Display(Name = "Promotion ID")]
            public int PromotionId { get; set; }
            [Display(Name = "Promotion Name")]
            public string PromotionName { get; set; }
            [Display(Name = "Description")]
            public string PromotionDetails { get; set; }
            [Display(Name = "Discount")]
            public Nullable<int> PromotionDiscount { get; set; }
            [Display(Name = "Status")]
            public Nullable<bool> PromotionStatus { get; set; }
            [Display(Name = "Open")]
            public Nullable<System.DateTime> PromotionOpen { get; set; }
            [Display(Name = "Close")]
            public Nullable<System.DateTime> PromotionClose { get; set; }
        }
    }
}