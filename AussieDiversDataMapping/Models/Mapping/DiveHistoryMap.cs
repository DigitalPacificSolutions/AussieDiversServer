using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class DiveHistoryMap : EntityTypeConfiguration<DiveHistory>
    {
        public DiveHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.DiveHistoryID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DiveHistory");
            this.Property(t => t.DiveHistoryID).HasColumnName("DiveHistoryID");
            this.Property(t => t.DiveSiteID).HasColumnName("DiveSiteID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");

            // Relationships
            this.HasRequired(t => t.DiveSite)
                .WithMany(t => t.DiveHistories)
                .HasForeignKey(d => d.DiveSiteID);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.DiveHistories)
                .HasForeignKey(d => d.PersonID);

        }
    }
}
