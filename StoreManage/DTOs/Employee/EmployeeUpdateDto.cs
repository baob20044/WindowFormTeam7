using StoreManage.DTOs.Employee;
using System;
using System.ComponentModel.DataAnnotations;

namespace StoreManage.DTOs.Employee
{
    public class EmployeeUpdateDto
    {
        public EmployeePersonalInfo PersonalInfo { get; set; }
        public string Email { get; set; }

    }
}