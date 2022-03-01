using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Auto
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string Brand { get; }
        public string Fuel { get; set; }
        public double EngineVolume { get; set; }
        public int FuelLevel { get; set; }
        public int Distance { get; set; }
        public int PneuState { get; set; }

        public Vehicle(string brand)
        {
            Type = "Unknown";
            Brand = brand;
            Fuel = "Gas";
            EngineVolume = 1000;
            FuelLevel = 100;
            Distance = 0;
            PneuState = 100;
        }
    }
}
