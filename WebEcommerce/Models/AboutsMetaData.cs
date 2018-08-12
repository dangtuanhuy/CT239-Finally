using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebEcommerce.Models
{
    [MetadataTypeAttribute(typeof(About.AboutsMetaData))]
    public partial class About
    {
        internal sealed class AboutsMetaData
        {
            [Display(Name = "About ID")]
            public int AboutId { get; set; }
            [Display(Name = "About Us")]
            public string AboutUs { get; set; }
     
            [Display(Name = "About Details")]
            public string AboutDetails { get; set; }
            [Display(Name = "About Employee")]
            public string EmployeeCode { get; set; }

        }
    }
}