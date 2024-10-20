using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WxHs.DTO
{
    public class BHInfo
    {
        public int Xh { get; set; }
        public string Bhno { get; set; }
        public string Gg { get; set; }
        public int Jlzt { get; set; }
        public string State { get; set; }
        public int Isdata { get; set; }
        public string Dcbz { get; set; }
        public DateTime Dcrq { get; set; }

        public DateTime Rq { get; set; }
        public string Cjry { get; set; }
        public string Cjrymc { get; set; }

        public bool IsChecked { get; set; }
    }
}
