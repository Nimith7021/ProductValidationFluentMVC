using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using FluentNHibernateDemo.Models;
using NHibernate.Mapping;

namespace FluentNHibernateDemo.Mappings
{
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Products");
            Id(p=>p.Id).GeneratedBy.Identity();
            Map(p => p.Name).Not.Nullable();
            Map(p => p.Description);
        }
    }
}