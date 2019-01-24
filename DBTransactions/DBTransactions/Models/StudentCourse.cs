using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBTransactions.Models
{
    public class StudentCourse
    {
        public int ID { get; set; }
        public int StrudentID { get; set; }
        public int CourseID { get; set; }
    }
}
