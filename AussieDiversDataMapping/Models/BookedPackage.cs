using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class BookedPackage
    {
        public BookedPackage()
        {
            this.BookingDetails = new List<BookingDetail>();
        }

        public short BookedPackageID { get; set; }
        public short PackageID { get; set; }
        public short BookingID { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Package Package { get; set; }
    }
}
