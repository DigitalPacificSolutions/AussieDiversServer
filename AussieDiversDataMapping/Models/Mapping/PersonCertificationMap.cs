using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class PersonCertificationMap : EntityTypeConfiguration<PersonCertification>
    {
        public PersonCertificationMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonCertificationID);

            // Properties
            this.Property(t => t.PC_PADI_ID)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PersonCertification");
            this.Property(t => t.PersonCertificationID).HasColumnName("PersonCertificationID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.CertificationID).HasColumnName("CertificationID");
            this.Property(t => t.PC_Date).HasColumnName("PC_Date");
            this.Property(t => t.PC_PADI_ID).HasColumnName("PC_PADI_ID");

            // Relationships
            this.HasRequired(t => t.Certification)
                .WithMany(t => t.PersonCertifications)
                .HasForeignKey(d => d.CertificationID);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonCertifications)
                .HasForeignKey(d => d.PersonID);

        }
    }
}
