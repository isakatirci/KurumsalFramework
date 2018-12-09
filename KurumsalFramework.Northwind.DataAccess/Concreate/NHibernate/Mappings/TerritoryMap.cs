using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using KurumsalFramework.Northwind.Entities;
using KurumsalFramework.Northwind.Entities.Concreate;

namespace KurumsalFramework.Northwind.DataAccess.NHibernate.Mappings {
    
    
    public partial class TerritoryMap : ClassMap<Territory> {
        
        public TerritoryMap() {
			Table("Territories");
			LazyLoad();
			Id(x => x.TerritoryId).GeneratedBy.Assigned().Column("TerritoryID");
			References(x => x.Region).Column("RegionID");
			Map(x => x.TerritoryDescription).Column("TerritoryDescription").Not.Nullable().Length(50);
        }
    }
}
