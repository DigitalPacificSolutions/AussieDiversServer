using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class Certification
    {
        public Certification()
        {
            this.PersonCertifications = new List<PersonCertification>();
        }

        public short CertificationID { get; set; }
        public string CertificationName { get; set; }
        public string CertificationDescription { get; set; }
        public string CertificationLevel { get; set; }
        public virtual ICollection<PersonCertification> PersonCertifications { get; set; }
    }
}
