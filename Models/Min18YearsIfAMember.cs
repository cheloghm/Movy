using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movy.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.unkown 
                || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            else if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");
            else
            { 
                var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
                return (age >= 18) 
                    ? ValidationResult.Success 
                    : new ValidationResult("Customer must be at least 18 years old to be a member.");
            }

        }
    }
}