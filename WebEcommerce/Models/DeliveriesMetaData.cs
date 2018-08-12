using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebEcommerce.Models
{
    [MetadataTypeAttribute(typeof(Delivery.DeliveriesMetaData))]
    public partial class Delivery
    {
        internal sealed class DeliveriesMetaData
        {
            [Display(Name = "Delivery ID")]
            public int DeliveryId { get; set; }
            [Display(Name = "Delivery Title")]
            public string DeliveryTitle { get; set; }
            [Display(Name = "Delivery Details")]
            public string DeliveryDetails { get; set; }
            [Display(Name = "Delivery Question")]
            public string DeliveryQuestion { get; set; }
            [Display(Name = "Delivery Img")]
            public string DeliveryImg { get; set; }
            [Display(Name = "Delivery EmployeeCode")]
            public string EmployeeCode { get; set; }

        }
    }
}