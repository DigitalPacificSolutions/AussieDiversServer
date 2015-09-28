using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class Package
    {
        public Package()
        {
            this.BookedPackages = new List<BookedPackage>();
        }

        public short PackageID { get; set; }
        public string PackageName { get; set; }
        public short PackageNumberOfDays { get; set; }
        public decimal PackageCost { get; set; }
        public virtual ICollection<BookedPackage> BookedPackages { get; set; }
    }
}
