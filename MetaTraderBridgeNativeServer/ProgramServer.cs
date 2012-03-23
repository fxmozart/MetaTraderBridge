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
            //NativePipeServer.Run();
            NativePipeServer.Create();
            NativePipeServer.Send();
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }
}
