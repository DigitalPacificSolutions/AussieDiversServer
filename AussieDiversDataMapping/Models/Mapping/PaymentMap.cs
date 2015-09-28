using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class PaymentMap : EntityTypeConfiguration<Payment>
    {
        public PaymentMap()
        {
            // Primary Key
            this.HasKey(t => t.PaymentID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Payment");
            this.Property(t => t.PaymentID).HasColumnName("PaymentID");
            this.Property(t => t.BookingID).HasColumnName("BookingID");
            this.Property(t => t.PaymentAmount).HasColumnName("PaymentAmount");
            this.Property(t => t.PaymentBalance).HasColumnName("PaymentBalance");
            this.Property(t => t.MethodID).HasColumnName("MethodID");

            // Relationships
            this.HasRequired(t => t.Booking)
                .WithMany(t => t.Payments)
                .HasForeignKey(d => d.BookingID);
            this.HasRequired(t => t.PaymentMethod)
                .WithMany(t => t.Payments)
                .HasForeignKey(d => d.MethodID);

        }
    }
}
