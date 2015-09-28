using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class PersonHotel
    {
        public short PersonHotelID { get; set; }
        public short HotelID { get; set; }
        public int BookingDetailsID { get; set; }
        public Nullable<short> PH_RoomNumber { get; set; }
        public string PH_RoomPhone { get; set; }
        public virtual BookingDetail BookingDetail { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
