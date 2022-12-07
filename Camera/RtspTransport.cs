using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera
{
    public enum RtspTransport
    {
        Undefined = 0,
        Udp = 1,
        Tcp = 2,
        UdpMulticast = 3,
        Http = 4
    }
}
