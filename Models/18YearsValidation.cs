﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidtermProject.Models
{
    public class _18YearsValidation : ValidationAttribute 
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var student = (Student)validationContext.ObjectInstance;
            var dateOfBirth = Convert.ToDateTime(value);

            var currentDateYear = DateTime.Now.Year;
            var dateOfBirthYear = dateOfBirth.Year;

            if (currentDateYear - dateOfBirthYear > 18)
                return ValidationResult.Success;

            return new ValidationResult("Student must be older than 18 years");
        }
    }
}