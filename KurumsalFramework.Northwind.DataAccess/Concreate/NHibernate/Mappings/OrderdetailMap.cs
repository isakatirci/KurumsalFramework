using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using KurumsalFramework.Northwind.Entities;
using KurumsalFramework.Northwind.Entities.Concreate;

namespace KurumsalFramework.Northwind.DataAccess.NHibernate.Mappings {
    
    
    public partial class OrderdetailMap : ClassMap<OrderDetail> {
        
        public OrderdetailMap() {
			Table("Order Details");
			LazyLoad();
			CompositeId().KeyProperty(x => x.OrderId, "OrderID")
			             .KeyProperty(x => x.ProductId, "ProductID");
			References(x => x.Order).Column("OrderID");
			References(x => x.Product).Column("ProductID");
			Map(x => x.UnitPrice).Column("UnitPrice").Not.Nullable().Precision(19).Scale(4);
			Map(x => x.Quantity).Column("Quantity").Not.Nullable().Precision(5);
			Map(x => x.Discount).Column("Discount").Not.Nullable().Precision(24);
        }

    }
}
