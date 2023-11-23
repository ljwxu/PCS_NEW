using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Common.Modbus
{
    public class ModbusRequest
    {
        public RequestTypes RequestType { get; set; }
        public byte SlaveAddress { get; set; }
        public ushort StartAddress { get; set; }
        public ushort NmbOfPoints { get; set; }

        public ushort RequestAddress { get; set; }
        public ushort Value { get; set; }

        public byte[] Result;

        public bool IsReturn = false;
        public bool IsSuccess = false;

        public ModbusRequest() { }
    }

    public enum RequestTypes
    {
        None = 0,
        Write = 1,
        Read = 2,
    }
}
