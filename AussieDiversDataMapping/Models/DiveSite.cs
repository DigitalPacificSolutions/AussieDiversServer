using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class DiveSite
    {
        public DiveSite()
        {
            this.DiveHistories = new List<DiveHistory>();
            this.Schedules = new List<Schedule>();
        }

        public short DiveSiteID { get; set; }
        public string DiveSiteLocationName { get; set; }
        public string DiveSiteDescription { get; set; }
        public virtual ICollection<DiveHistory> DiveHistories { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
