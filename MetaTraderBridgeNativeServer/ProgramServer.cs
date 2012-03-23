using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaTraderBridgeNativeServer
{
    class ProgramServer
    {
        static void Main(string[] args)
        {
            NativePipeServer.Run();
            //Console.WriteLine("press any key to exit...");
            //Console.ReadKey();
        }
    }
}
