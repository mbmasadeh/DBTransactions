using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBTransactions.ViewModel
{
    public class ResultsViewModel
    {
        public string message { get; set; }
        public bool status { get; set; }
        public dynamic data { get; set; }
    }
}
