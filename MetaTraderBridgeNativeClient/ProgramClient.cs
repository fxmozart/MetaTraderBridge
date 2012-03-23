using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaTraderBridgeNativeClient
{
    class ProgramClient
    {
        static void Main(string[] args)
        {
            NativePipeClient.CreateClientPipe();
            //Console.WriteLine("press any key to exit...");
            //Console.ReadKey();
        }
    }
}
