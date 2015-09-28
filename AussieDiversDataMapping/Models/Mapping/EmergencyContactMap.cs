using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class EmergencyContactMap : EntityTypeConfiguration<EmergencyContact>
    {
        public EmergencyContactMap()
        {
            // Primary Key
            this.HasKey(t => t.EmergencyContactID);

            // Properties
            this.Property(t => t.EC_FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EC_LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EC_Country)
                .HasMaxLength(50);

            this.Property(t => t.EC_PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.EC_Relationship)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EmergencyContact");
            this.Property(t => t.EmergencyContactID).HasColumnName("EmergencyContactID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.EC_FirstName).HasColumnName("EC_FirstName");
            this.Property(t => t.EC_LastName).HasColumnName("EC_LastName");
            this.Property(t => t.EC_Country).HasColumnName("EC_Country");
            this.Property(t => t.EC_PhoneNumber).HasColumnName("EC_PhoneNumber");
            this.Property(t => t.EC_Relationship).HasColumnName("EC_Relationship");

            // Relationships
            this.HasRequired(t => t.Person)
                .WithMany(t => t.EmergencyContacts)
                .HasForeignKey(d => d.PersonID);

        }
    }
}
