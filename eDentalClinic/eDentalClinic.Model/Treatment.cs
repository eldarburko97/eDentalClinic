﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalClinic.Model
{
   public class Treatment
    {
        public int TreatmentID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int TimeRequired { get; set; }
        public byte[] Image { get; set; }

        public  ICollection<BranchTreatment> BranchTreatments { get; set; }
    }
}
