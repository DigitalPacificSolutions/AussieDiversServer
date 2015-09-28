using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace AussieDiversDataMapping.Models
{
    public partial class Person
    {
        public Person()
        {
            this.BookingDetails = new List<BookingDetail>();
            this.CommunicationHistories = new List<CommunicationHistory>();
            this.DiveHistories = new List<DiveHistory>();
            this.EmergencyContacts = new List<EmergencyContact>();
            this.PersonCertifications = new List<PersonCertification>();
        }

        public int PersonID { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public string PersonEmail { get; set; }
        public System.DateTime PersonDOB { get; set; }
        public Nullable<System.DateTime> PersonLastDiveDate { get; set; }
        public Nullable<short> PersonNumberOfDives { get; set; }
        public string PersonStreetAddress1 { get; set; }
        public string PersonStreetAddress2 { get; set; }
        public string PersonCity { get; set; }
        public string PersonStateProvinceTerritory { get; set; }
        public string PersonCountry { get; set; }
        public string PersonPostalCode { get; set; }
        public string PersonPhone { get; set; }
        public string PersonVegetarian { get; set; }
        public string PersonAllergies { get; set; }
        public byte[] PersonPhoto { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual ICollection<CommunicationHistory> CommunicationHistories { get; set; }
        public virtual ICollection<DiveHistory> DiveHistories { get; set; }
        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
        public virtual ICollection<PersonCertification> PersonCertifications { get; set; }
    }
}
