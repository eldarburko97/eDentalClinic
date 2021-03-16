using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalClinic.Model
{
    public class DentistBranch
    {
        public int DentistBranchID { get; set; }
        public int DentistID { get; set; }
        public int BranchID { get; set; }

        public Dentist Dentist { get; set; }
        public Branch Branch { get; set; }
    }
}
