using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class HotelMap : EntityTypeConfiguration<Hotel>
    {
        public HotelMap()
        {
            // Primary Key
            this.HasKey(t => t.HotelID);

            // Properties
            this.Property(t => t.HotelName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HotelStreetAddress)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.HotelCity)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.HotelStateProvinceTerritory)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.HotelCountry)
                .HasMaxLength(100);

            this.Property(t => t.HotelPostalCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.HotelPhoneNumber)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Hotel");
            this.Property(t => t.HotelID).HasColumnName("HotelID");
            this.Property(t => t.BeachID).HasColumnName("BeachID");
            this.Property(t => t.HotelName).HasColumnName("HotelName");
            this.Property(t => t.HotelStreetAddress).HasColumnName("HotelStreetAddress");
            this.Property(t => t.HotelCity).HasColumnName("HotelCity");
            this.Property(t => t.HotelStateProvinceTerritory).HasColumnName("HotelStateProvinceTerritory");
            this.Property(t => t.HotelCountry).HasColumnName("HotelCountry");
            this.Property(t => t.HotelPostalCode).HasColumnName("HotelPostalCode");
            this.Property(t => t.HotelPhoneNumber).HasColumnName("HotelPhoneNumber");
            this.Property(t => t.HotelDirections).HasColumnName("HotelDirections");

            // Relationships
            this.HasRequired(t => t.Beach)
                .WithMany(t => t.Hotels)
                .HasForeignKey(d => d.BeachID);

        }
    }
}
