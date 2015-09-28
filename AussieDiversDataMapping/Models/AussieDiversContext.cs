using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AussieDiversDataMapping.Models.Mapping;

namespace AussieDiversDataMapping.Models
{
    public partial class AussieDiversContext : DbContext
    {
        static AussieDiversContext()
        {
            Database.SetInitializer<AussieDiversContext>(null);
        }

        public AussieDiversContext()
            : base("Name=AussieDiversContext")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Beach> Beaches { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<BookedPackage> BookedPackages { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CommunicationHistory> CommunicationHistories { get; set; }
        public DbSet<DiveHistory> DiveHistories { get; set; }
        public DbSet<DiveSite> DiveSites { get; set; }
        public DbSet<EmergencyContact> EmergencyContacts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentHistory> EquipmentHistories { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonCertification> PersonCertifications { get; set; }
        public DbSet<PersonHotel> PersonHotels { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BeachMap());
            modelBuilder.Configurations.Add(new BoatMap());
            modelBuilder.Configurations.Add(new BookedPackageMap());
            modelBuilder.Configurations.Add(new BookingMap());
            modelBuilder.Configurations.Add(new BookingDetailMap());
            modelBuilder.Configurations.Add(new CertificationMap());
            modelBuilder.Configurations.Add(new CommunicationHistoryMap());
            modelBuilder.Configurations.Add(new DiveHistoryMap());
            modelBuilder.Configurations.Add(new DiveSiteMap());
            modelBuilder.Configurations.Add(new EmergencyContactMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EquipmentMap());
            modelBuilder.Configurations.Add(new EquipmentHistoryMap());
            modelBuilder.Configurations.Add(new EquipmentTypeMap());
            modelBuilder.Configurations.Add(new HotelMap());
            modelBuilder.Configurations.Add(new PackageMap());
            modelBuilder.Configurations.Add(new PaymentMap());
            modelBuilder.Configurations.Add(new PaymentMethodMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PersonCertificationMap());
            modelBuilder.Configurations.Add(new PersonHotelMap());
            modelBuilder.Configurations.Add(new RentalMap());
            modelBuilder.Configurations.Add(new ScheduleMap());
        }
    }
}
