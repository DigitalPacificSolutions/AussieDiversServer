using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class BeachMap : EntityTypeConfiguration<Beach>
    {
        public BeachMap()
        {
            // Primary Key
            this.HasKey(t => t.BeachID);

            // Properties
            this.Property(t => t.BeachName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Beach");
            this.Property(t => t.BeachID).HasColumnName("BeachID");
            this.Property(t => t.BeachName).HasColumnName("BeachName");
        }
    }
}
