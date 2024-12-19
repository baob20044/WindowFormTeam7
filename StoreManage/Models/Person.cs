
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using StoreManage.CustomerValidation;

namespace StoreManage.Models
{
    public class Person
    {
        [Required]
        [DefaultValue("")]
        public string FirstName { get; set; }

        [Required]
        [DefaultValue("")]
        public  string LastName { get; set; } 

        [Required]
        public bool Male { get; set; }

        [Required]
        [DefaultValue("")]
        public  string PhoneNumber { get; set; } 
        
        [Required]
        [DefaultValue("")]
        public  string Address { get; set; } 
        
        [Required]
        [MinAge(18)]
        public  string DateOfBirth { get; set; }
    }
}
