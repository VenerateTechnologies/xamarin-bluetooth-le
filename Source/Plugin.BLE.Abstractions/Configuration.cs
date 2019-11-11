using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.BLE
{
    public static class Configuration
    {
        public static class SPP
        {
            public static bool IsSPP { get; set; } = false;

            internal static object Lock { get; set; } = new object();
        }

        public static bool IsForceUI { get; set; } = false;
    }
}
