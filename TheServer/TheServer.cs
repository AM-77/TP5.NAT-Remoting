using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

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

                RemotingConfiguration.RegisterWellKnownServiceType(typeof(StackFactory.StackFactory), "StackFactory", WellKnownObjectMode.Singleton);

                String netremoting = "   _   _ _____ _____   ____                      _   _             \n  | \\ | | ____|_   _| |  _ \\ ___ _ __ ___   ___ | |_(_)_ __   __ _ \n  |  \\| |  _|   | |   | |_) / _ \\ '_ ` _ \\ / _ \\| __| | '_ \\ / _` |\n _| |\\  | |___  | |   |  _ <  __/ | | | | | (_) | |_| | | | | (_| |\n(_)_| \\_|_____| |_|   |_| \\_\\___|_| |_| |_|\\___/ \\__|_|_| |_|\\__, |\n                                                             |___/ ";
                Console.WriteLine(netremoting);

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
