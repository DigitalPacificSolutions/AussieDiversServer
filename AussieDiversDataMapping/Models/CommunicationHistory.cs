using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class CommunicationHistory
    {
        public short NoteID { get; set; }
        public int PersonID { get; set; }
        public string CH_Comment { get; set; }
        public string CH_Status { get; set; }
        public string CH_Source { get; set; }
        public Nullable<System.DateTime> CH_Date { get; set; }
        public virtual Person Person { get; set; }
    }
}
