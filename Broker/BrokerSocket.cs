using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Broker
{
    class BrokerSocket
    {
        private Socket _socket;

        public BrokerSocket()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start(string ipAddress, int port)
        {
            _socket.Bind(new IPEndPoint(IPAddress.Parse(ipAddress), port));
            _socket.Listen(8);
            Accept();
        }

        private void Accept()
        {
            _socket.BeginAccept(AcceptedCallback, null);
        }

        private void AcceptedCallback(IAsyncResult result) 
        {

        }

    }
}
