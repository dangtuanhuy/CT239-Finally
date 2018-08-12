using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebEcommerce.Models
{
    [MetadataTypeAttribute(typeof(Employee.EmployeesMetaData))]
    public partial class Employee
    {
        internal sealed class EmployeesMetaData
        {
            [Display(Name = "EmployeeCode")]
            public string EmployeeCode { get; set; }
            [Display(Name = "Employee Pass")]
            public string EmployeePass { get; set; }
            [Display(Name = "Employee LastName")]
            public string LastName { get; set; }
            [Display(Name = "Employee FirstName")]
            public string FirstName { get; set; }
            [Display(Name = "Employee Title")]
            public string Title { get; set; }
            [Display(Name = "Employee TitleOfCourtesy")]
            public string TitleOfCourtesy { get; set; }
            [Display(Name = "Employee BirthDate")]
            public Nullable<System.DateTime> BirthDate { get; set; }
            [Display(Name = "Employee HireDate")]
            public Nullable<System.DateTime> HireDate { get; set; }
            [Display(Name = "Employee Address")]
            public string Address { get; set; }
            [Display(Name = "Employee PostalCode")]
            public string PostalCode { get; set; }
            [Display(Name = "Employee HomePhone")]
            public string HomePhone { get; set; }
            [Display(Name = "Employee Extension")]
            public string Extension { get; set; }
            [Display(Name = "Employee Img")]
            public string EmployeeImg { get; set; }
            [Display(Name = "Employee Notes")]
            public string Notes { get; set; }
            [Display(Name = "Employee ReportsTo")]
            public Nullable<int> ReportsTo { get; set; }
            [Display(Name = "Employee RoleId")]
            public Nullable<int> RoleId { get; set; }
        }
    }
}