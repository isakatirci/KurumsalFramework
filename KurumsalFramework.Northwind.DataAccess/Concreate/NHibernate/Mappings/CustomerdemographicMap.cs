using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using KurumsalFramework.Northwind.Entities;
using KurumsalFramework.Northwind.Entities.Concreate;

namespace KurumsalFramework.Northwind.DataAccess.NHibernate.Mappings {
    
    
    public partial class CustomerdemographicMap : ClassMap<CustomerDemographic> {
        
        public CustomerdemographicMap() {
			Table("CustomerDemographics");
			LazyLoad();
			Id(x => x.CustomerTypeId).GeneratedBy.Assigned().Column("CustomerTypeID");
			Map(x => x.CustomerDesc).Column("CustomerDesc").Length(1073741823);
        }
    }
}
