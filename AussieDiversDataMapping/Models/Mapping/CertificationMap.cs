using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class CertificationMap : EntityTypeConfiguration<Certification>
    {
        public CertificationMap()
        {
            // Primary Key
            this.HasKey(t => t.CertificationID);

            // Properties
            this.Property(t => t.CertificationName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CertificationDescription)
                .HasMaxLength(50);

            this.Property(t => t.CertificationLevel)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Certification");
            this.Property(t => t.CertificationID).HasColumnName("CertificationID");
            this.Property(t => t.CertificationName).HasColumnName("CertificationName");
            this.Property(t => t.CertificationDescription).HasColumnName("CertificationDescription");
            this.Property(t => t.CertificationLevel).HasColumnName("CertificationLevel");
        }
    }
}
