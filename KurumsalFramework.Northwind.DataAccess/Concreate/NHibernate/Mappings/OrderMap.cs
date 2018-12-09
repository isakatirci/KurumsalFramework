using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using KurumsalFramework.Northwind.Entities;
using KurumsalFramework.Northwind.Entities.Concreate;

namespace KurumsalFramework.Northwind.DataAccess.NHibernate.Mappings {
    
    
    public partial class OrderMap : ClassMap<Order> {
        
        public OrderMap() {
			Table("Orders");
			LazyLoad();
			Id(x => x.OrderId).GeneratedBy.Identity().Column("OrderID");
			References(x => x.Customer).Column("CustomerID");
			References(x => x.Employee).Column("EmployeeID");
			References(x => x.Shipper).Column("ShipVia");
			Map(x => x.OrderDate).Column("OrderDate");
			Map(x => x.RequiredDate).Column("RequiredDate");
			Map(x => x.ShippedDate).Column("ShippedDate");
			Map(x => x.Freight).Column("Freight").Precision(19).Scale(4);
			Map(x => x.ShipName).Column("ShipName").Length(40);
			Map(x => x.ShipAddress).Column("ShipAddress").Length(60);
			Map(x => x.ShipCity).Column("ShipCity").Length(15);
			Map(x => x.ShipRegion).Column("ShipRegion").Length(15);
			Map(x => x.ShipPostalCode).Column("ShipPostalCode").Length(10);
			Map(x => x.ShipCountry).Column("ShipCountry").Length(15);
			HasMany(x => x.OrderDetails).KeyColumn("OrderID");
        }
    }
}
