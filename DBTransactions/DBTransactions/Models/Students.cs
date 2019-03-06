using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBTransactions.Models
{
    public class Students
    {
        [Key]
        public int ID { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string MobNumber { get; set; }
        public virtual ICollection<StudentCourse> Courses { get; set; }
    }
}
