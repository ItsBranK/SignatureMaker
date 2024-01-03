using System;

namespace SignatureMaker.Framework
{
    public static class Assembly
    {
        private static readonly bool _x64Bit = true;
        private static readonly string _title = "ItsBranK's Signature Maker";
        private static readonly string _version = "2.7";

        public static bool Is64Bit() { return _x64Bit; }
        public static string GetTitle() { return (_title + (Is64Bit() ? " (x64)" : " (x86)")); }
        public static string GetVersion() { return _version; }
    }
}