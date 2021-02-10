using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalClinicWebAPI.Database
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDatea { get; set; }
        public int ClientID { get; set; }
        public int DentistID { get; set; }
        public bool RatingStatus { get; set; }
        public bool CommentStatus { get; set; }
    }
}
