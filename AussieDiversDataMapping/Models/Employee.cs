using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.BookingDetails = new List<BookingDetail>();
        }

        public short EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeInstructorType { get; set; }
        public string EmployeeCertificationLevel { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
