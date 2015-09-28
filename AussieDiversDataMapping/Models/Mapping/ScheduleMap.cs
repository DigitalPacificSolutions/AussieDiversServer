using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class ScheduleMap : EntityTypeConfiguration<Schedule>
    {
        public ScheduleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ScheduleID, t.BoatID, t.DiveSiteID, t.ScheduleDayOfWeek });

            // Properties
            this.Property(t => t.ScheduleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BoatID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiveSiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ScheduleDayOfWeek)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("Schedule");
            this.Property(t => t.ScheduleID).HasColumnName("ScheduleID");
            this.Property(t => t.BoatID).HasColumnName("BoatID");
            this.Property(t => t.DiveSiteID).HasColumnName("DiveSiteID");
            this.Property(t => t.ScheduleDayOfWeek).HasColumnName("ScheduleDayOfWeek");

            // Relationships
            this.HasRequired(t => t.Boat)
                .WithMany(t => t.Schedules)
                .HasForeignKey(d => d.BoatID);
            this.HasRequired(t => t.DiveSite)
                .WithMany(t => t.Schedules)
                .HasForeignKey(d => d.DiveSiteID);

        }
    }
}
