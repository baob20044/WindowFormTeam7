
using StoreManage.DTOs.Employee;
using System;

namespace api.DTOs.Employee
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public EmployeePersonalInfo PersonalInfo { get; set; }
        public decimal Salary { get; set; }
        public string StartDate { get; set; }
        public int ContractUpTo { get; set; }
    }
}