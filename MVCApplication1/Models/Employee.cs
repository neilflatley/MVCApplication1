using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCApplication1.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeID { get; set; }

        [Display(Name = "First name")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(40)]
        public string FirstName { get; set; }

        [Display(Name = "Middle initial")]
        [StringLength(40)]
        public string MiddleInitial { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(40)]
        public string LastName { get; set; }

        [Display(Name = "Start date")]
        [Required(ErrorMessage = "Start date is required")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Employee create date")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Employee amend date")]
        public DateTime? AmendDate { get; set; }

    }

    public class salesDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}