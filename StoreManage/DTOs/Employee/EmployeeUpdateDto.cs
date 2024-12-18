using StoreManage.DTOs.Employee;
using System;
using System.ComponentModel.DataAnnotations;

namespace StoreManage.DTOs.Employee
{
    public class EmployeeUpdateDto
    {
        public EmployeePersonalInfo PersonalInfo { get; set; }
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Start date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format (yyyy-MM-dd)")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "ContractUpTo is required.")]
        public int ContractUpTo { get; set; }

        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string ParentPhoneNumber { get; set; }
    }
}