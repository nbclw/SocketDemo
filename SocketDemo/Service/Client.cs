using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Client
    {
        public string Token { get; set; }

        public Socket SocketServer { get; set; }
    }
}
