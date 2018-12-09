using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using KurumsalFramework.Northwind.Entities;
using KurumsalFramework.Northwind.Entities.Concreate;

namespace KurumsalFramework.Northwind.DataAccess.NHibernate.Mappings {
	
	
	public partial class CategoryMap : ClassMap<Category> {
		
		public CategoryMap() {
			Table("Categories");
			LazyLoad();
			Id(x => x.CategoryId).GeneratedBy.Identity().Column("CategoryID");
			Map(x => x.CategoryName).Column("CategoryName").Not.Nullable().Length(15);
			Map(x => x.Description).Column("Description").Length(1073741823);
			Map(x => x.Picture).Column("Picture").Length(2147483647);
			HasMany(x => x.Products).KeyColumn("CategoryID");
		}
	}
}
