using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class BookedPackageMap : EntityTypeConfiguration<BookedPackage>
    {
        public BookedPackageMap()
        {
            // Primary Key
            this.HasKey(t => t.BookedPackageID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BookedPackage");
            this.Property(t => t.BookedPackageID).HasColumnName("BookedPackageID");
            this.Property(t => t.PackageID).HasColumnName("PackageID");
            this.Property(t => t.BookingID).HasColumnName("BookingID");

            // Relationships
            this.HasRequired(t => t.Booking)
                .WithMany(t => t.BookedPackages)
                .HasForeignKey(d => d.BookingID);
            this.HasRequired(t => t.Package)
                .WithMany(t => t.BookedPackages)
                .HasForeignKey(d => d.PackageID);

        }
    }
}
