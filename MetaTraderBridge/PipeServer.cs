using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Pipes;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using RGiesecke.DllExport;

namespace MetaTraderBridge
{
    public class PipeServer
    {
        // added comment here to test/learn git

        //static void Main(string[] args)
        [DllExport("SendString", CallingConvention = CallingConvention.StdCall)]
        public static void SendString(string args)
        {
            using (NamedPipeServerStream pipeServer = new NamedPipeServerStream("testpipe",
                                                                                 PipeDirection.InOut))
            {
                //Console.WriteLine("NamedPipeServerStream object created.");

                // Wait for a client to connect
                //Console.Write("Waiting for client connection...");
                pipeServer.WaitForConnection();
                //Console.WriteLine("Client connected.");

                //bool Disconnect = false;
                try
                {
                    // Read user input and send that to the client process.
                    using (StreamWriter sw = new StreamWriter(pipeServer))
                    {
                        //string temp;
                        //while (pipeServer.IsConnected && !Disconnect)
                        //{   
                        sw.AutoFlush = true;
                        //Console.Write("Enter text: ");
                        //temp = Console.ReadLine();
                        //if (temp == "exit") Disconnect = true;
                        //Disconnect = true;
                        sw.WriteLine(args);
                        //}
                    }
                }
                // Catch the IOException that is raised if the pipe is 
                // broken or disconnected.
                catch (IOException e)
                {
                    Console.WriteLine("ERROR: {0}", e.Message);
                }

            }
        }
    }
}