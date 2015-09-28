using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class BookingDetail
    {
        public BookingDetail()
        {
            this.PersonHotels = new List<PersonHotel>();
            this.Rentals = new List<Rental>();
        }

        public int BookingDetailsID { get; set; }
        public short BookedPackageID { get; set; }
        public int PersonID { get; set; }
        public short BookedEmployeeID { get; set; }
        public short BoatID { get; set; }
        public System.DateTime BD_DiveDate { get; set; }
        public string BD_Status { get; set; }
        public string BD_CustomerHotel { get; set; }
        public string BD_PickupLocation { get; set; }
        public virtual Boat Boat { get; set; }
        public virtual BookedPackage BookedPackage { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<PersonHotel> PersonHotels { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
        public virtual Person Person { get; set; }
    }
}
