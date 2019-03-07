using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBTransactions.ViewModel
{
    public class RootObjectViewModel
    {
        public List<CourseID> CourseID { get; set; }
    }
    public class CourseID
    {
        public int ID { get; set; }
    }
}
