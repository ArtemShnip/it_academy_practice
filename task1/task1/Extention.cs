using System;
using System.Collections.Generic;
using System.Text;

namespace Project14_1
{
    static class Extention
    {
        public static string Cut(this String text)
        {
            return text.Substring(0, 5) + "...";
        }
    }
}
