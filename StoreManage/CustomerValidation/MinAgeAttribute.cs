using System;
using System.ComponentModel.DataAnnotations;

namespace StoreManage.CustomerValidation
{
    public class MinAgeAttribute : ValidationAttribute
    {
        private readonly int _minimumAge;

        public MinAgeAttribute(int minimumAge)
        {
            _minimumAge = minimumAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Value is null");

            if (!(value is DateTime dateOfBirth))
            {
                return new ValidationResult("Invalid date of birth format.");
            }

            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if (today < dateOfBirth.AddYears(age))
            {
                age--;
            }

            if (age < _minimumAge)
            {
                return new ValidationResult($"Age must be at least {_minimumAge} years.");
            }

            return ValidationResult.Success;
        }
    }
}
