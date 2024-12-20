
using StoreManage.DTOs.Employee;
using System;

namespace api.DTOs.Employee
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public EmployeePersonalInfo PersonalInfo { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
    }
}