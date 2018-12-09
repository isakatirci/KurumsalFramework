using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using KurumsalFramework.Northwind.Entities;
using KurumsalFramework.Northwind.Entities.Concreate;

namespace KurumsalFramework.Northwind.DataAccess.NHibernate.Mappings {
    
    
    public partial class RegionMap : ClassMap<Region> {
        
        public RegionMap() {
			Table("Region");
			LazyLoad();
			Id(x => x.RegionId).GeneratedBy.Identity().Column("RegionID");
			Map(x => x.RegionDescription).Column("RegionDescription").Not.Nullable().Length(50);
			HasMany(x => x.Territories).KeyColumn("RegionID");
        }
    }
}
