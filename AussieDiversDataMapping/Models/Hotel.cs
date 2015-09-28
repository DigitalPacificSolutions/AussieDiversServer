using System;
using System.Collections.Generic;

namespace AussieDiversDataMapping.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            this.PersonHotels = new List<PersonHotel>();
        }

        public short HotelID { get; set; }
        public short BeachID { get; set; }
        public string HotelName { get; set; }
        public string HotelStreetAddress { get; set; }
        public string HotelCity { get; set; }
        public string HotelStateProvinceTerritory { get; set; }
        public string HotelCountry { get; set; }
        public string HotelPostalCode { get; set; }
        public string HotelPhoneNumber { get; set; }
        public string HotelDirections { get; set; }
        public virtual Beach Beach { get; set; }
        public virtual ICollection<PersonHotel> PersonHotels { get; set; }
    }
}
