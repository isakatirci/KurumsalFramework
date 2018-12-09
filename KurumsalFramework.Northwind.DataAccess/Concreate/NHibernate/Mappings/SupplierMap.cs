using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using KurumsalFramework.Northwind.Entities;
using KurumsalFramework.Northwind.Entities.Concreate;

namespace KurumsalFramework.Northwind.DataAccess.NHibernate.Mappings {
    
    
    public partial class SupplierMap : ClassMap<Supplier> {
        
        public SupplierMap() {
			Table("Suppliers");
			LazyLoad();
			Id(x => x.SupplierId).GeneratedBy.Identity().Column("SupplierID");
			Map(x => x.CompanyName).Column("CompanyName").Not.Nullable().Length(40);
			Map(x => x.ContactName).Column("ContactName").Length(30);
			Map(x => x.ContactTitle).Column("ContactTitle").Length(30);
			Map(x => x.Address).Column("Address").Length(60);
			Map(x => x.City).Column("City").Length(15);
			Map(x => x.Region).Column("Region").Length(15);
			Map(x => x.PostalCode).Column("PostalCode").Length(10);
			Map(x => x.Country).Column("Country").Length(15);
			Map(x => x.Phone).Column("Phone").Length(24);
			Map(x => x.Fax).Column("Fax").Length(24);
			Map(x => x.HomePage).Column("HomePage").Length(1073741823);
			HasMany(x => x.Products).KeyColumn("SupplierID");
        }
    }
}
