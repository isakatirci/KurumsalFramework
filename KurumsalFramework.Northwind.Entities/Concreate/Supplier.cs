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

    // Suppliers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public partial class Supplier : IEntity
    {
         public virtual int SupplierId { get; set; } // SupplierID (Primary key)
         public virtual string CompanyName { get; set; } // CompanyName (length: 40)
         public virtual string ContactName { get; set; } // ContactName (length: 30)
         public virtual string ContactTitle { get; set; } // ContactTitle (length: 30)
         public virtual string Address { get; set; } // Address (length: 60)
         public virtual string City { get; set; } // City (length: 15)
         public virtual string Region { get; set; } // Region (length: 15)
         public virtual string PostalCode { get; set; } // PostalCode (length: 10)
         public virtual string Country { get; set; } // Country (length: 15)
         public virtual string Phone { get; set; } // Phone (length: 24)
         public virtual string Fax { get; set; } // Fax (length: 24)
         public virtual string HomePage { get; set; } // HomePage (length: 1073741823)

        // Reverse navigation

        /// <summary>
        /// Child Products where [Products].[SupplierID] point to this entity (FK_Products_Suppliers)
        /// </summary>
        public virtual System.Collections.Generic.IList<Product> Products { get; set; } // Products.FK_Products_Suppliers

        public Supplier()
        {
            Products = new System.Collections.Generic.List<Product>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
