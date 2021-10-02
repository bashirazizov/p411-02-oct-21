using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Song
    {
        public string Name;
        public string Genre;
        private double _length;
        public Singer Singer;

        private int _SumOfRatings;
        private int _CountOfRatings;

        public double Length { 
            get {
                return _length;
            } 
            set {
                if (value>0)
                {
                    _length = value;
                }
                else
                {
                    Console.WriteLine("Uzunluq yanlisdir");
                }
            } 
        }

        public void AddRating(int rating)
        {
            if (rating>=0&&rating<=5)
            {
                _SumOfRatings += rating;
                _CountOfRatings++;
            }
        }

        public double GetRating()
        {
            return _SumOfRatings / _CountOfRatings;
        }

        //public Song(string name, string genre, double length, Singer singer)
        //{
        //    Name = name;
        //    Genre = genre;
        //    Length = length;
        //    Singer = singer;
        //}

        public override string ToString()
        {
            return $"{Name} {Length}";
        }
    }
}
