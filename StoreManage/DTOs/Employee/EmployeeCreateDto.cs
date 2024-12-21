using System;
using System.ComponentModel.DataAnnotations;

namespace StoreManage.DTOs.Employee
{
    public class EmployeeCreateDto
    {
        public EmployeePersonalInfo PersonalInfo { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; } = string.Empty;

    }
}
