using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eDentalClinic.Model.Requests
{
   public class DentistBranchInsertRequest
    {
        [Required]
        public int DentistID { get; set; }
        [Required]
        public int BranchID { get; set; }
    }
}
