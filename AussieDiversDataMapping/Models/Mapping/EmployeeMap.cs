using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeID);

            // Properties
            this.Property(t => t.EmployeeFirstName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.EmployeeLastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EmployeeInstructorType)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EmployeeCertificationLevel)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Employee");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.EmployeeFirstName).HasColumnName("EmployeeFirstName");
            this.Property(t => t.EmployeeLastName).HasColumnName("EmployeeLastName");
            this.Property(t => t.EmployeeInstructorType).HasColumnName("EmployeeInstructorType");
            this.Property(t => t.EmployeeCertificationLevel).HasColumnName("EmployeeCertificationLevel");
        }
    }
}
