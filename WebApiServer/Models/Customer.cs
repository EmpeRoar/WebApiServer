using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiServer.Models
{

    public enum CustomerStatus
    {
        active,disabled
    }
    public class Customer : IEntity
    {
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"[a-zA-Z\-\s]*$", ErrorMessage = "Invalid Characters")]
        [Display(Name = "Firstname")]
        public string FirstName { get; set; }


        [Required]
        [StringLength(30)]
        [RegularExpression(@"[a-zA-Z\-\s]*$", ErrorMessage = "Invalid Characters")]
        [Display(Name = "Middlename")]
        public string MiddleName { get; set; }


        [Required]
        [StringLength(30)]
        [RegularExpression(@"[a-zA-Z\-\s]*$", ErrorMessage = "Invalid Characters")]
        [Display(Name = "Lastname")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        public CustomerStatus CustomerStatus { get; set; }


        [Display(Name = "Updated")]
        public DateTime? Updated { get; set; }

        [Display(Name = "Deleted")]
        public DateTime? Deleted { get; set; }

        [Display(Name = "Created")]
        public DateTime Created { get; set; }
    }
}