using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Qt
{
    public class FontDatabase
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        protected static extern void qt_fontdatabase_add(string font);
        public static void AddApplicationFont(string font)
        {
            qt_fontdatabase_add(font);
        }
    }
}