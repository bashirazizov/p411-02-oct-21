using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MotoredVehicle
    {
        public string Model;
        public string Make;
        protected int ProdYear;
        public string MotorSize;
        private readonly string Color;

        public MotoredVehicle()
        { }

        public MotoredVehicle(string Model, string Make, int ProdYear)
        {
            this.Model = Model;
            this.Make = Make;
            this.ProdYear = ProdYear;
        }
        public MotoredVehicle(string Model, string Make, int ProdYear, string color):this(Model,Make,ProdYear)
        {
            Color = color;
        }

        public string GetInfo()
        {
            return $"{Make} {Model}";
        }

        public virtual string GetDetailedInfo()
        {
            return $"{GetInfo()} {Color}";
        }
    }
}
