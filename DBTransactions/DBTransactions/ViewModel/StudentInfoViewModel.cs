using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBTransactions.ViewModel
{
    public class StudentInfoViewModel
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public List<string> Courses { get; set; }
    }
}
