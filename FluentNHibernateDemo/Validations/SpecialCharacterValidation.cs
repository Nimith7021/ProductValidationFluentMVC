using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace FluentNHibernateDemo.Validations
{
    public class SpecialCharacterValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string name = value.ToString();
                string regex = @"[^a-zA-Z0-9\s]";
                bool checkMatch = Regex.IsMatch(name, regex);
                if (checkMatch) {
                    return new ValidationResult("Contains Special Character");
                }
                else
                {
                    return ValidationResult.Success;
                }

            }

            return new ValidationResult("Error");
        }
    }
}