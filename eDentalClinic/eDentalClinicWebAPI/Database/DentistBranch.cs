using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalClinicWebAPI.Database
{
    public class DentistBranch
    {
        public int DentistBranchID { get; set; }
        public int DentistID { get; set; }
        public int BranchID { get; set; }

        public virtual Dentist Dentist { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
