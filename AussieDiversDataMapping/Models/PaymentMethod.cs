using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            this.Payments = new List<Payment>();
        }

        public short MethodID { get; set; }
        public string PM_Name { get; set; }
        public string PM_Description { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
