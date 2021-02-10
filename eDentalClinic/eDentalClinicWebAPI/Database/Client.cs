using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalClinicWebAPI.Database
{
    public class Client
    {
        public int ClientID { get; set; }
        public int CityID { get; set; }
        public int GenderID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "date")]
        public DateTime Birthdate { get; set; }
        public byte[] Image { get; set; }
    }
}
