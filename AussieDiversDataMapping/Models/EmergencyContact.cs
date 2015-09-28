using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class EmergencyContact
    {
        public short EmergencyContactID { get; set; }
        public int PersonID { get; set; }
        public string EC_FirstName { get; set; }
        public string EC_LastName { get; set; }
        public string EC_Country { get; set; }
        public string EC_PhoneNumber { get; set; }
        public string EC_Relationship { get; set; }
        public virtual Person Person { get; set; }
    }
}
