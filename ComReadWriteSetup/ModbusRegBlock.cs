using System;
using System.Collections.Generic;
using System.Text;

namespace ComReadWrite
{
    class ModbusRegBlock
    {
        public int SLNo { get; set; }
        public int BLK { get; set; }
        public int ADD { get; set; }
        public string FLDN { get; set; }
        public bool END { get; set; }
        public string FLDT { get; set; }
        public bool CFLD { get; set; }
        public int WORD { get; set; }
        public string RES { get; set; }
        public string SFAC { get; set; }
    }
}
