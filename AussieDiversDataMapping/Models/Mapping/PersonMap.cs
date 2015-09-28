using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AussieDiversDataMapping.Models.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonID);

            // Properties
            this.Property(t => t.PersonFirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PersonLastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PersonEmail)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PersonStreetAddress1)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.PersonStreetAddress2)
                .HasMaxLength(75);

            this.Property(t => t.PersonCity)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.PersonStateProvinceTerritory)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.PersonCountry)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.PersonPostalCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PersonPhone)
                .HasMaxLength(20);

            this.Property(t => t.PersonVegetarian)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Person");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.PersonFirstName).HasColumnName("PersonFirstName");
            this.Property(t => t.PersonLastName).HasColumnName("PersonLastName");
            this.Property(t => t.PersonEmail).HasColumnName("PersonEmail");
            this.Property(t => t.PersonDOB).HasColumnName("PersonDOB");
            this.Property(t => t.PersonLastDiveDate).HasColumnName("PersonLastDiveDate");
            this.Property(t => t.PersonNumberOfDives).HasColumnName("PersonNumberOfDives");
            this.Property(t => t.PersonStreetAddress1).HasColumnName("PersonStreetAddress1");
            this.Property(t => t.PersonStreetAddress2).HasColumnName("PersonStreetAddress2");
            this.Property(t => t.PersonCity).HasColumnName("PersonCity");
            this.Property(t => t.PersonStateProvinceTerritory).HasColumnName("PersonStateProvinceTerritory");
            this.Property(t => t.PersonCountry).HasColumnName("PersonCountry");
            this.Property(t => t.PersonPostalCode).HasColumnName("PersonPostalCode");
            this.Property(t => t.PersonPhone).HasColumnName("PersonPhone");
            this.Property(t => t.PersonVegetarian).HasColumnName("PersonVegetarian");
            this.Property(t => t.PersonAllergies).HasColumnName("PersonAllergies");
            this.Property(t => t.PersonPhoto).HasColumnName("PersonPhoto");
        }
    }
}
