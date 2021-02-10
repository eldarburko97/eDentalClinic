using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalClinicWebAPI.Database
{
    public class TreatmentType
    {
        public int TreatmentTypeID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int TimeRequired { get; set; }
    }
}
