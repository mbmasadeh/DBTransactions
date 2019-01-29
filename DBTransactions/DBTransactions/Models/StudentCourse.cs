using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBTransactions.Models
{
    public class StudentCourse
    {
        [Key]
        public int ID { get; set; }
        public Students Sttudents { get; set; }
        public int StrudentID { get; set; }
        public Courses Courses { get; set; }
        public int CourseID { get; set; }
    }
}
