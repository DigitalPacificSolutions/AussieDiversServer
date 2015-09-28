using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class PaymentMethodMap : EntityTypeConfiguration<PaymentMethod>
    {
        public PaymentMethodMap()
        {
            // Primary Key
            this.HasKey(t => t.MethodID);

            // Properties
            this.Property(t => t.PM_Name)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PaymentMethod");
            this.Property(t => t.MethodID).HasColumnName("MethodID");
            this.Property(t => t.PM_Name).HasColumnName("PM_Name");
            this.Property(t => t.PM_Description).HasColumnName("PM_Description");
        }
    }
}
