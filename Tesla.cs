using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {

        }
        public void Turn(string direction) 
        {
            Console.WriteLine($"The {MainColor} Tesla squeals around a {direction} turn.");
        }
        public void Stop() 
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you, MMmmmmmmmm!");
        }
    }
}