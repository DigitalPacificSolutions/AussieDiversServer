using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class PersonHotelMap : EntityTypeConfiguration<PersonHotel>
    {
        public PersonHotelMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonHotelID);

            // Properties
            this.Property(t => t.PH_RoomPhone)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PersonHotel");
            this.Property(t => t.PersonHotelID).HasColumnName("PersonHotelID");
            this.Property(t => t.HotelID).HasColumnName("HotelID");
            this.Property(t => t.BookingDetailsID).HasColumnName("BookingDetailsID");
            this.Property(t => t.PH_RoomNumber).HasColumnName("PH_RoomNumber");
            this.Property(t => t.PH_RoomPhone).HasColumnName("PH_RoomPhone");

            // Relationships
            this.HasRequired(t => t.BookingDetail)
                .WithMany(t => t.PersonHotels)
                .HasForeignKey(d => d.BookingDetailsID);
            this.HasRequired(t => t.Hotel)
                .WithMany(t => t.PersonHotels)
                .HasForeignKey(d => d.HotelID);

        }
    }
}
