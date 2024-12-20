
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using StoreManage.CustomerValidation;

namespace StoreManage.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public  string LastName { get; set; } 
        public bool Male { get; set; }
        public  string PhoneNumber { get; set; } 
        public  string Address { get; set; } 
        public  string DateOfBirth { get; set; }
    }
}
