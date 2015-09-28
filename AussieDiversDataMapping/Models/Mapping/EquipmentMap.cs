using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class EquipmentMap : EntityTypeConfiguration<Equipment>
    {
        public EquipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.EquipmentID);

            // Properties
            this.Property(t => t.EquipmentName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EquipmentSize)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Equipment");
            this.Property(t => t.EquipmentID).HasColumnName("EquipmentID");
            this.Property(t => t.EquipmentName).HasColumnName("EquipmentName");
            this.Property(t => t.EquipmentDescription).HasColumnName("EquipmentDescription");
            this.Property(t => t.EquipmentRentalCost).HasColumnName("EquipmentRentalCost");
            this.Property(t => t.EquipmentSize).HasColumnName("EquipmentSize");
        }
    }
}
