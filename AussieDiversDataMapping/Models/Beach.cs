using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class Beach
    {
        public Beach()
        {
            this.Hotels = new List<Hotel>();
        }

        public short BeachID { get; set; }
        public string BeachName { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
