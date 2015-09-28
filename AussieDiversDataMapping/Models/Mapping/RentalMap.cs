using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class RentalMap : EntityTypeConfiguration<Rental>
    {
        public RentalMap()
        {
            // Primary Key
            this.HasKey(t => t.RentalID);

            // Properties
            this.Property(t => t.RentalStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Rental");
            this.Property(t => t.RentalID).HasColumnName("RentalID");
            this.Property(t => t.EquipmentID).HasColumnName("EquipmentID");
            this.Property(t => t.BookingDetailsID).HasColumnName("BookingDetailsID");
            this.Property(t => t.RentalStatus).HasColumnName("RentalStatus");

            // Relationships
            this.HasRequired(t => t.BookingDetail)
                .WithMany(t => t.Rentals)
                .HasForeignKey(d => d.BookingDetailsID);
            this.HasRequired(t => t.Equipment)
                .WithMany(t => t.Rentals)
                .HasForeignKey(d => d.EquipmentID);

        }
    }
}
