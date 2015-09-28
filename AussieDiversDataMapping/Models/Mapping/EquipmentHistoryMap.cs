using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class EquipmentHistoryMap : EntityTypeConfiguration<EquipmentHistory>
    {
        public EquipmentHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.EquipmentHistoryID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EquipmentHistory");
            this.Property(t => t.EquipmentHistoryID).HasColumnName("EquipmentHistoryID");
            this.Property(t => t.EquipmentID).HasColumnName("EquipmentID");
            this.Property(t => t.EH_RetailCost).HasColumnName("EH_RetailCost");
            this.Property(t => t.EH_DatePurchased).HasColumnName("EH_DatePurchased");

            // Relationships
            this.HasRequired(t => t.Equipment)
                .WithMany(t => t.EquipmentHistories)
                .HasForeignKey(d => d.EquipmentID);

        }
    }
}
