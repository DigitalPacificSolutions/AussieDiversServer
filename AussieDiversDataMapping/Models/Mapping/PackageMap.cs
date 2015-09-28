using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class PackageMap : EntityTypeConfiguration<Package>
    {
        public PackageMap()
        {
            // Primary Key
            this.HasKey(t => t.PackageID);

            // Properties
            this.Property(t => t.PackageName)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Package");
            this.Property(t => t.PackageID).HasColumnName("PackageID");
            this.Property(t => t.PackageName).HasColumnName("PackageName");
            this.Property(t => t.PackageNumberOfDays).HasColumnName("PackageNumberOfDays");
            this.Property(t => t.PackageCost).HasColumnName("PackageCost");
        }
    }
}
