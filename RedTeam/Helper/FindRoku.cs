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
            string textToSend = request.ToString();

            // encode the request into bytes
            byte[] send_buffer = Encoding.ASCII.GetBytes(textToSend);

            // send call
            sending_socket.SendTo(send_buffer, receivingEndpoint);
        }
        
        
        public static IPAddress HearRoku()
        {
            CallRoku();

            IPAddress rokuIP = null;
            int listenPort = 60000;

            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint listenerEP = new IPEndPoint(IPAddress.Any, listenPort);
            string receivedData;
            byte[] receiveByteArray;

            receiveByteArray = listener.Receive(ref listenerEP);
            receivedData = Encoding.ASCII.GetString(receiveByteArray, 0, receiveByteArray.Length);


            //Need to add code to parse the receivedData to get the roku IPaddress. But untill I know the format I can't do it just yet.
            return rokuIP;
        }
    }
}