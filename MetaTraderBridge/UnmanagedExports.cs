using System;
using System.Collections.Generic;
using System.Text;
using RGiesecke.DllExport;

namespace MetaTraderBridge
{
   internal static class UnmanagedExports
   {
      [DllExport("adddays", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
      static double AddDays(double dateValue, int days)
      {
         return DateTime.FromOADate(dateValue).AddDays(days).ToOADate();
      }
   }
}
