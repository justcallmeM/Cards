using System;
using System.ComponentModel.DataAnnotations;

namespace Cards.UI.Web.Models
{
    public class DateValidate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime currentDate = DateTime.Now;
            string message = string.Empty;

            if (Convert.ToDateTime(value).Date < currentDate.Date)
            {
                message = "Date cannot be less than current date";
                return new ValidationResult(message);
            }

            return ValidationResult.Success;
        }
    }
}