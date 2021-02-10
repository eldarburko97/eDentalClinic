using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalClinicWebAPI.Database
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int CustomerID { get; set; }
        public int? DentistID { get; set; }
        public int? TopicID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
