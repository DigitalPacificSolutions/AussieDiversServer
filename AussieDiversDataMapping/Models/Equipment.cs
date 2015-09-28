using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            this.EquipmentHistories = new List<EquipmentHistory>();
            this.EquipmentTypes = new List<EquipmentType>();
            this.Rentals = new List<Rental>();
        }

        public short EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentDescription { get; set; }
        public decimal EquipmentRentalCost { get; set; }
        public string EquipmentSize { get; set; }
        public virtual ICollection<EquipmentHistory> EquipmentHistories { get; set; }
        public virtual ICollection<EquipmentType> EquipmentTypes { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
