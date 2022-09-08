using RTTIScanner;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFinder
{
    internal class Modules
    {
        public static long AppOffset()
        {
            Process gt = Process.GetProcessesByName("Growtopia").First();
            Int32 appBase = 0x400000;
            Int32 appBaseIncrement = 0x600000;
            long baseAddress = (long)gt.MainModule.BaseAddress;
            long pointerToApp = gt.Handle.ScanClassName(baseAddress + appBase, "App", 0x600000);
            long offsetToApp;

            while (pointerToApp == 0)
            {
                appBase += appBaseIncrement;
                pointerToApp = gt.Handle.ScanClassName(baseAddress + appBase, "App", 0x600000);
            }
            offsetToApp = pointerToApp - baseAddress;
            return offsetToApp;
        }

        public static long AppPointer()
        {
            Process gt = Process.GetProcessesByName("Growtopia").First();
            Int32 appBase = 0x400000;
            Int32 appBaseIncrement = 0x600000;
            long baseAddress = (long)gt.MainModule.BaseAddress;
            long pointerToApp = gt.Handle.ScanClassName(baseAddress + appBase, "App", 0x600000);

            while (pointerToApp == 0)
            {
                appBase += appBaseIncrement;
                pointerToApp = gt.Handle.ScanClassName(baseAddress + appBase, "App", 0x600000);
            }
            return pointerToApp;
        }
    }
}
