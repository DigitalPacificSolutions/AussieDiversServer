using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class EquipmentType
    {
        public short EquipmentTypeID { get; set; }
        public short EquipmentID { get; set; }
        public string EquipmentType1 { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
