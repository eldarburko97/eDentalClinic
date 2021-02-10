using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalClinicWebAPI.Database
{
    public class Topic
    {
        public int TopicID { get; set; }
        public int CustomerID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
    }
}
