using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FluentNHibernateDemo.Validations
{
    public class FirstCharacterUpperCaseCheck:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string description = value.ToString();
                if (char.IsUpper(description[0]))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("First Character Should be UpperCase");
                }
            }

            return new ValidationResult("Error");
        }
    }
}