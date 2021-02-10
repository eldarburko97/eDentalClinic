using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalClinicWebAPI.Database
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int ClientID { get; set; }
        public int DentistID { get; set; }
        public int DentistRating { get; set; }
    }
}
