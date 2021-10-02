using System;

namespace MyUtils
{
    public class Computer
    {
        public Computer()
        {
            Console.WriteLine("comp yaradildi");
        }
        public string Brand { get; set; }
        protected string Model { get; set; }
        internal int RamSize { get; set; }
        private string CpuName { get; set; }
    }

}
