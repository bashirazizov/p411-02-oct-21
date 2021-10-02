using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car : MotoredVehicle
    {
        public int FuelTankSize;
        public int FuelAmount;
        public int FuelUsedPerKm;
        public bool IsOn;
        public Car(string Model, string Make, int ProdYear):base(Model,Make,ProdYear)
        {}

        public void TurnOn()
        {
            IsOn = true;
        }

        public void TurnOff()
        {
            IsOn = false;
        }

        public int GetProdYear()
        {
            return ProdYear;
        }

        public string Go(int distance)
        {
            if (IsOn)
            {
                if (FuelAmount>=(distance*FuelUsedPerKm))
                {
                    FuelAmount -= (distance * FuelUsedPerKm);
                    return $"{distance} kms distance covered.";
                }
                else
                {
                    return "Not enought fuel";
                }
            }
            else
            {
                return "Car is off";
            }
        }

        public override string GetDetailedInfo()
        {
            return $"{base.GetDetailedInfo()} {FuelAmount}";
        }
    }
}
