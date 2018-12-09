using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using StackFactory;

namespace TheServer
{
    class TheServer
    {
        public static void Main(string[] args)
        {
            try
            {
                TcpChannel tcpChannel = new TcpChannel(1234);
                ChannelServices.RegisterChannel(tcpChannel, false);

                RemotingConfiguration.RegisterWellKnownServiceType(typeof(StackFactory.StackFactory), "uPile", WellKnownObjectMode.Singleton);

                Console.Write("[+] The server is running ...  \n[INFO] Rememeber to activate win32 in .bashrc");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.Write("[!] There was an error in the serverMain : {0}", e.Message);
            }
        }
    }
}
