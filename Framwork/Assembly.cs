using System;

namespace SignatureMaker.Framework
{
    public static class Assembly
    {
        private static readonly bool m_x64Bit = true;
        private static readonly string m_title = "ItsBranK's Signature Maker";
        private static readonly string m_version = "2.8";

        public static bool Is64Bit() { return m_x64Bit; }
        public static string GetTitle() { return (m_title + (Is64Bit() ? " (x64)" : " (x86)")); }
        public static string GetVersion() { return m_version; }
    }
}