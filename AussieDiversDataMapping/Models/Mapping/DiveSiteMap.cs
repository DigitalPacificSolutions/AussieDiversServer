using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class DiveSiteMap : EntityTypeConfiguration<DiveSite>
    {
        public DiveSiteMap()
        {
            // Primary Key
            this.HasKey(t => t.DiveSiteID);

            // Properties
            this.Property(t => t.DiveSiteLocationName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DiveSite");
            this.Property(t => t.DiveSiteID).HasColumnName("DiveSiteID");
            this.Property(t => t.DiveSiteLocationName).HasColumnName("DiveSiteLocationName");
            this.Property(t => t.DiveSiteDescription).HasColumnName("DiveSiteDescription");
        }
    }
}
