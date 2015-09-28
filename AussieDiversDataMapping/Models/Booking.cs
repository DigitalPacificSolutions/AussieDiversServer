using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class Booking
    {
        public Booking()
        {
            this.BookedPackages = new List<BookedPackage>();
            this.Payments = new List<Payment>();
        }

        public short BookingID { get; set; }
        public System.DateTime BookingDate { get; set; }
        public string BookingStatus { get; set; }
        public virtual ICollection<BookedPackage> BookedPackages { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
