using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaTraderBridgeNativeServer
{
    class ProgramServer
    {
        static void Main()
        {

            NativePipeServer.CreateServerPipe();

            // SendServerPipe() currently only handles sending a string to the client
            // to do: implement sending multiple types (int, double, long, etc.)
            NativePipeServer.SendServerPipe();
        }
    }
}
