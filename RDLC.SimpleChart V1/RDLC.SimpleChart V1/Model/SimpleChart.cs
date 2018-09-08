using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDLC.SimpleChart_V1.Model
{
    public class SimpleChart
    {
        public int ID { get; set; }
        public string SERIES { get; set; }
        public decimal X1 { get; set; }
        public decimal X2 { get; set; }
        public decimal Y1 { get; set; }
        public decimal Y2 { get; set; }
        public string COMMENT { get; set; }
    }
}
