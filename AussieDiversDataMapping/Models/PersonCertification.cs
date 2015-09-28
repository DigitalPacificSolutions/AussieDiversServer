using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class PersonCertification
    {
        public short PersonCertificationID { get; set; }
        public int PersonID { get; set; }
        public short CertificationID { get; set; }
        public System.DateTime PC_Date { get; set; }
        public string PC_PADI_ID { get; set; }
        public virtual Certification Certification { get; set; }
        public virtual Person Person { get; set; }
    }
}
