using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class EquipmentTypeMap : EntityTypeConfiguration<EquipmentType>
    {
        public EquipmentTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.EquipmentTypeID);

            // Properties
            this.Property(t => t.EquipmentType1)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("EquipmentType");
            this.Property(t => t.EquipmentTypeID).HasColumnName("EquipmentTypeID");
            this.Property(t => t.EquipmentID).HasColumnName("EquipmentID");
            this.Property(t => t.EquipmentType1).HasColumnName("EquipmentType");

            // Relationships
            this.HasRequired(t => t.Equipment)
                .WithMany(t => t.EquipmentTypes)
                .HasForeignKey(d => d.EquipmentID);

        }
    }
}
