using System;
using System.ComponentModel.DataAnnotations;

namespace StoreManage.DTOs.Employee
{
    public class EmployeeCreateDto
    {
        public EmployeePersonalInfo PersonalInfo { get; set; }
        public decimal Salary { get; set; }

        public string StartDate { get; set; }

        public int ContractUpTo { get; set; }

        public string ParentPhoneNumber { get; set; } = string.Empty;
    }
}
