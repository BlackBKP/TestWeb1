using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb1.Models
{
    public class EmpModel
    {
        public string name { get; set; }
        public string position { get; set; }
        public DateTime arrived { get; set; }
        public DateTime depart_time { get; set; }
        public int absent { get; set; }
        public int late { get; set; }
    }
}
