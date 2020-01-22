using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_12
{
    class Figures
    {
        public int Side { get; set; }

        public string Name { get; set; }

        public double Area { get; set; }

        public override string ToString()
        {
            return $"This is {Name}. CLRType is {Side}. Area is {Area} ";
        }
    }
}
