using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FluentNHibernateDemo.Validations;

namespace FluentNHibernateDemo.Models
{
    public class Product
    {
        public virtual int Id { get; set; }

        [Required]
        [NameLengthValidator]
        [SpecialCharacterValidation]
        [FirstCharacterUpperCaseCheck]
        public virtual string Name { get; set; }

        [Required]
        [StringLength(15,ErrorMessage = "Description exceeds specified range")]
        [FirstCharacterUpperCaseCheck]
        [SpecialCharacterValidation]
        public virtual string Description { get; set; }
    }
}