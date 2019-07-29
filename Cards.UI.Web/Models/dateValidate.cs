using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cards.UI.Web.Models
{
    public class DateValidate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime currentDate = DateTime.Now;
            string message = string.Empty;

            if(Convert.ToDateTime(value) < currentDate)
            {
                message = "Date cannot be less than current date";
                return new ValidationResult(message);
            }

            return ValidationResult.Success;
        }
    }
}