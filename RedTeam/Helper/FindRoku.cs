using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RedTeam.Models;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RedTeam.Helper
{
    public class FindRoku
    {
        private static void CallRoku()
        {
            Boolean done = false;
            Boolean exception_thrown = false;

            // configure sending socket
            Socket sending_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            // set ssdp address and port
            IPAddress receivingAddress = IPAddress.Parse("192.168.2.255");
            IPEndPoint receivingEndpoint = new IPEndPoint(receivingAddress, 1900);

            // write the request message
            var request = new StringBuilder();
            request.AppendLine("M-SEARCH * HTTP/1.1");
            request.AppendLine("HOST: 239.255.255.250:1900");
            request.AppendLine("MAN: \"ssdp:discover\"");
            request.AppendLine("ST: roku:ecp");
            request.AppendLine("");
            string textToSend = request;

            // encode the request into bytes
            byte[] send_buffer = Encoding.ASCII.GetBytes(request);



        }
        
        
        
        
        public static IPAddress HearRoku()
        {
            CallRoku();


        }
    }
}