using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using KurumsalFramework.Northwind.Entities;
using KurumsalFramework.Northwind.Entities.Concreate;

namespace KurumsalFramework.Northwind.DataAccess.NHibernate.Mappings {
	
	
	public partial class EmployeeMap : ClassMap<Employee> {
		
		public EmployeeMap() {
			Table("Employees");
			LazyLoad();
			Id(x => x.EmployeeId).GeneratedBy.Identity().Column("EmployeeID");
			//References(x => x.Employees).Column("ReportsTo");
			Map(x => x.LastName).Column("LastName").Not.Nullable().Length(20);
			Map(x => x.FirstName).Column("FirstName").Not.Nullable().Length(10);
			Map(x => x.Title).Column("Title").Length(30);
			Map(x => x.TitleOfCourtesy).Column("TitleOfCourtesy").Length(25);
			Map(x => x.BirthDate).Column("BirthDate");
			Map(x => x.HireDate).Column("HireDate");
			Map(x => x.Address).Column("Address").Length(60);
			Map(x => x.City).Column("City").Length(15);
			Map(x => x.Region).Column("Region").Length(15);
			Map(x => x.PostalCode).Column("PostalCode").Length(10);
			Map(x => x.Country).Column("Country").Length(15);
			Map(x => x.HomePhone).Column("HomePhone").Length(24);
			Map(x => x.Extension).Column("Extension").Length(4);
			Map(x => x.Photo).Column("Photo").Length(2147483647);
			Map(x => x.Notes).Column("Notes").Length(1073741823);
			Map(x => x.PhotoPath).Column("PhotoPath").Length(255);
			HasMany(x => x.Employees).KeyColumn("ReportsTo");
			HasMany(x => x.Orders).KeyColumn("EmployeeID");
		}
	}
}
