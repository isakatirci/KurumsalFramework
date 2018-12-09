using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using KurumsalFramework.Northwind.Entities;
using KurumsalFramework.Northwind.Entities.Concreate;

namespace KurumsalFramework.Northwind.DataAccess.NHibernate.Mappings {
    
    
    public partial class ShipperMap : ClassMap<Shipper> {
        
        public ShipperMap() {
			Table("Shippers");
			LazyLoad();
			Id(x => x.ShipperId).GeneratedBy.Identity().Column("ShipperID");
			Map(x => x.CompanyName).Column("CompanyName").Not.Nullable().Length(40);
			Map(x => x.Phone).Column("Phone").Length(24);
			HasMany(x => x.Orders).KeyColumn("ShipVia");
        }
    }
}
