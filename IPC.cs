using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;



namespace ZPLSharp
{

    public static class ZPLIPC
    {
        const string name = "IPC";
        static Dictionary<string, SocketMap> SocketMapping = new Dictionary<string, SocketMap>();

        public static bool AddZebraMapping(string mapping, string ip, int port)
        {
            mapping = mapping.ToLower();
            if (SocketMapping.ContainsKey(mapping))
            {
                return false;
            }
            SocketMapping.Add(mapping, new SocketMap(mapping, ip, port));
            return true;
        }

        public static string SendWithResponse(string mapping, string message)
        {
            string routine = "FrwSendWithResponse";
            var msg = new StringBuilder();
            try
            {
                var s = SendMessage(mapping, message);
                var rsp = new Byte[256];
                while (s.Receive(rsp) != 0)
                {
                    msg.Append(Encoding.ASCII.GetString(rsp));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Error(name, routine, ExceptionToString(ex));
            }
            return msg.ToString();
        }

        public static void SendWithNoResponse(string mapping, string message)
        {
            string routine = "FrwSendWithNoResponse";
            try
            {
                var s = SendMessage(mapping, message);
                s.Close();
            }
            catch (Exception ex)
            {
                Error(name, routine, ExceptionToString(ex));
            }
        }

        static Socket SendMessage(string mapping, string message)
        {
            string routine = "SendMessage";
            try
            {
                var dictmap = SocketMapping[mapping];
                var ipe = new IPEndPoint(IPAddress.Parse(dictmap.IP), dictmap.port);
                var s = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                var bytes = Encoding.ASCII.GetBytes(message);
                s.Connect(ipe);
                s.Send(bytes);
                return s;
            }
            catch (Exception ex)
            {
                Error(name, routine, ExceptionToString(ex));
            }
            return null;
        }

        static void Error(string name, string routine, string msg)
        {
            Console.WriteLine($"ZPLSHARP!::CLASS:{name}::FUNC:{routine}::MSG: {msg}");
        }

        static string ExceptionToString(Exception ex)
        {
            return $"Exception: {ex.Message}";
        }

        public class SocketMap
        {
            public string mapping { get; }
            public string IP { get; }
            public int port { get; }

            public SocketMap(string mapping, string IP, int port)
            {
                this.mapping = mapping;
                this.IP = IP;
                this.port = port;
            }
        }
    }
}
