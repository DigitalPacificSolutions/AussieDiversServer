using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class CommunicationHistoryMap : EntityTypeConfiguration<CommunicationHistory>
    {
        public CommunicationHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.NoteID);

            // Properties
            this.Property(t => t.CH_Status)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CH_Source)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("CommunicationHistory");
            this.Property(t => t.NoteID).HasColumnName("NoteID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.CH_Comment).HasColumnName("CH_Comment");
            this.Property(t => t.CH_Status).HasColumnName("CH_Status");
            this.Property(t => t.CH_Source).HasColumnName("CH_Source");
            this.Property(t => t.CH_Date).HasColumnName("CH_Date");

            // Relationships
            this.HasRequired(t => t.Person)
                .WithMany(t => t.CommunicationHistories)
                .HasForeignKey(d => d.PersonID);

        }
    }
}
