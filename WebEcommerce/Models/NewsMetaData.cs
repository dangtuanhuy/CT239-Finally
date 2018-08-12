using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebEcommerce.Models
{
    [MetadataTypeAttribute(typeof(News.NewsMetaData))]
    public partial class News
    {
        internal sealed class NewsMetaData
        {
            [Display(Name = "News Id")]
            public int NewsId { get; set; }
            [Display(Name = "News Titles")]
            public string NewTitles { get; set; }
            [Display(Name = "News Details")]
            public string NewsDetails { get; set; }
            [Display(Name = "News By")]
            public string NewsBy { get; set; }
            [Display(Name = "News Imgs")]
            public string NewsImgs { get; set; }
            [Display(Name = "News Date")]
            public Nullable<System.DateTime> NewsDate { get; set; }
            [Display(Name = "News EmployeeCode")]
            public string EmployeeCode { get; set; }
        }
    }
}