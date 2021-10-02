using System;
using System.Collections.Generic;
using System.Text;

namespace MyUtils
{
    class Laptop:Computer
    {
        public double ScreenSize { get; set; }
        public int getRam()
        {
            return RamSize;
        }
    }
}
