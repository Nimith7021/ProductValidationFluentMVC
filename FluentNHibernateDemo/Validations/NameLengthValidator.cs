using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FluentNHibernateDemo.Validations
{
    public class NameLengthValidator:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string name = value.ToString();
                if (name.Length < 10)
                    return ValidationResult.Success;
            }

            return new ValidationResult("Length of Product Name Exceeds");

        }
    }
}