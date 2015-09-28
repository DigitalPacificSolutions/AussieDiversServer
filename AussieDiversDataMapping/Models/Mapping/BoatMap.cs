using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class BoatMap : EntityTypeConfiguration<Boat>
    {
        public BoatMap()
        {
            // Primary Key
            this.HasKey(t => t.BoatID);

            // Properties
            this.Property(t => t.BoatName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BoatType)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Boat");
            this.Property(t => t.BoatID).HasColumnName("BoatID");
            this.Property(t => t.BoatName).HasColumnName("BoatName");
            this.Property(t => t.BoatCapacity).HasColumnName("BoatCapacity");
            this.Property(t => t.BoatType).HasColumnName("BoatType");
        }
    }
}
