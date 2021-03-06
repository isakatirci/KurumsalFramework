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


namespace KurumsalFramework.Northwind.DataAccess.Concreate.EntityFramework.Mappings
{
    using KurumsalFramework.Core.Entities;
    using KurumsalFramework.Northwind.Entities.Concreate;

    // Territories
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public partial class TerritoryMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Territory>
    {
        public TerritoryMapping()
            : this("dbo")
        {
        }

        public TerritoryMapping(string schema)
        {
            ToTable("Territories", schema);
            HasKey(x => x.TerritoryId);

            Property(x => x.TerritoryId).HasColumnName(@"TerritoryID").HasColumnType("nvarchar").IsRequired().HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TerritoryDescription).HasColumnName(@"TerritoryDescription").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(50);
            Property(x => x.RegionId).HasColumnName(@"RegionID").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.Region).WithMany(b => b.Territories).HasForeignKey(c => c.RegionId).WillCascadeOnDelete(false); // FK_Territories_Region
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
