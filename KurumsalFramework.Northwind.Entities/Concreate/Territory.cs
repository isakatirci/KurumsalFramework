// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace KurumsalFramework.Northwind.Entities.Concreate
{
    using KurumsalFramework.Core.Entities;

    // Territories
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public partial class Territory : IEntity
    {
         public virtual string TerritoryId { get; set; } // TerritoryID (Primary key) (length: 20)
         public virtual string TerritoryDescription { get; set; } // TerritoryDescription (length: 50)
         public virtual int RegionId { get; set; } // RegionID

        // Reverse navigation

        /// <summary>
        /// Child Employees (Many-to-Many) mapped by table [EmployeeTerritories]
        /// </summary>
        public virtual System.Collections.Generic.IList<Employee> Employees { get; set; } // Many to many mapping

        // Foreign keys

        /// <summary>
        /// Parent Region pointed by [Territories].([RegionId]) (FK_Territories_Region)
        /// </summary>
        public virtual Region Region { get; set; } // FK_Territories_Region

        public Territory()
        {
            Employees = new System.Collections.Generic.List<Employee>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
