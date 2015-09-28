using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class BookingDetailMap : EntityTypeConfiguration<BookingDetail>
    {
        public BookingDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.BookingDetailsID);

            // Properties
            this.Property(t => t.BD_Status)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BD_CustomerHotel)
                .HasMaxLength(50);

            this.Property(t => t.BD_PickupLocation)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BookingDetails");
            this.Property(t => t.BookingDetailsID).HasColumnName("BookingDetailsID");
            this.Property(t => t.BookedPackageID).HasColumnName("BookedPackageID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.BookedEmployeeID).HasColumnName("BookedEmployeeID");
            this.Property(t => t.BoatID).HasColumnName("BoatID");
            this.Property(t => t.BD_DiveDate).HasColumnName("BD_DiveDate");
            this.Property(t => t.BD_Status).HasColumnName("BD_Status");
            this.Property(t => t.BD_CustomerHotel).HasColumnName("BD_CustomerHotel");
            this.Property(t => t.BD_PickupLocation).HasColumnName("BD_PickupLocation");

            // Relationships
            this.HasRequired(t => t.Boat)
                .WithMany(t => t.BookingDetails)
                .HasForeignKey(d => d.BoatID);
            this.HasRequired(t => t.BookedPackage)
                .WithMany(t => t.BookingDetails)
                .HasForeignKey(d => d.BookedPackageID);
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.BookingDetails)
                .HasForeignKey(d => d.BookedEmployeeID);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.BookingDetails)
                .HasForeignKey(d => d.PersonID);

        }
    }
}
