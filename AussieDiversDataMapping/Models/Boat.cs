using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class Boat
    {
        public Boat()
        {
            this.BookingDetails = new List<BookingDetail>();
            this.Schedules = new List<Schedule>();
        }

        public short BoatID { get; set; }
        public string BoatName { get; set; }
        public short BoatCapacity { get; set; }
        public string BoatType { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
