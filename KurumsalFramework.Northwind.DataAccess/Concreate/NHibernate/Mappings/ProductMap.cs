using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using KurumsalFramework.Northwind.Entities;
using KurumsalFramework.Northwind.Entities.Concreate;

namespace KurumsalFramework.Northwind.DataAccess.NHibernate.Mappings {
    
    
    public partial class ProductMap : ClassMap<Product> {
        
        public ProductMap() {
			Table("Products");
			LazyLoad();
			Id(x => x.ProductId).GeneratedBy.Identity().Column("ProductID");
			References(x => x.Supplier).Column("SupplierID");
			References(x => x.Category).Column("CategoryID");
			Map(x => x.ProductName).Column("ProductName").Not.Nullable().Length(40);
			Map(x => x.QuantityPerUnit).Column("QuantityPerUnit").Length(20);
			Map(x => x.UnitPrice).Column("UnitPrice").Precision(19).Scale(4);
			Map(x => x.UnitsInStock).Column("UnitsInStock").Precision(5);
			Map(x => x.UnitsOnOrder).Column("UnitsOnOrder").Precision(5);
			Map(x => x.ReorderLevel).Column("ReorderLevel").Precision(5);
			Map(x => x.Discontinued).Column("Discontinued").Not.Nullable();
			HasMany(x => x.OrderDetails).KeyColumn("ProductID");
        }
    }
}
