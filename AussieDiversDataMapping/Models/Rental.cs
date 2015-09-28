using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class Rental
    {
        public short RentalID { get; set; }
        public short EquipmentID { get; set; }
        public int BookingDetailsID { get; set; }
        public string RentalStatus { get; set; }
        public virtual BookingDetail BookingDetail { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
