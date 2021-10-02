using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Singer
    {
        public string Name;
        public string SurName;
        public Song[] songs;

        public Singer(string name, string surname)
        {
            Name = name;
            SurName = surname;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {SurName}");

            foreach (Song item in songs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
