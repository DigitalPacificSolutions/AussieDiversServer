using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class BookingMap : EntityTypeConfiguration<Booking>
    {
        public BookingMap()
        {
            // Primary Key
            this.HasKey(t => t.BookingID);

            // Properties
            this.Property(t => t.BookingStatus)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Booking");
            this.Property(t => t.BookingID).HasColumnName("BookingID");
            this.Property(t => t.BookingDate).HasColumnName("BookingDate");
            this.Property(t => t.BookingStatus).HasColumnName("BookingStatus");
        }
    }
}
