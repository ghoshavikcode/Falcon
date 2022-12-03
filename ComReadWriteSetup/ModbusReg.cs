using System;
using System.Collections.Generic;
using System.Text;

namespace ComReadWrite
{
    class ModbusRegArray
    {
        public ModbusReg[] MREG { get; set; }
    }
    class ModbusReg
    {
        public int BLK { get; set; }
        public string SLV { get; set; }
        public string FC { get; set; }
        public int SADD { get; set; }
        public int WRDC { get; set; }
        public int PDLY { get; set; }
        public int GRP { get; set; }
        public string COM { get; set; }
        public string IP { get; set; }
        public int PORT { get; set; }
        public int DEV { get; set; }
        public ModbusRegBlock[] MBLK { get; set; }
    }
}
