using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBTransactions.Models
{
    public class Courses
    {
        [Key]
        public int ID { get; set; }
        public string CourseName { get; set; }
        public int Hours { get; set; }
        public virtual ICollection<StudentCourse> Students { get; set; }
    }
}
