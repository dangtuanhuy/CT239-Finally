using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebEcommerce.Models
{
    [MetadataTypeAttribute(typeof(Branch.BranchesMetaData))]
    public partial class Branch
    {
        internal sealed class BranchesMetaData
        {
            [Display(Name = "Branch ID")]
            public int BranchId { get; set; }
            [Display(Name = "Branch Name")]
            public string BranchName { get; set; }
            [Display(Name = "Branch Details")]
            public string BranchDetails { get; set; }
            [Display(Name = "Branch EmployeeCode")]
            public string EmployeeCode { get; set; }
        }
    }
}