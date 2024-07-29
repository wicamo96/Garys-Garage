using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {

        }
        public void Turn(string direction) 
        {
            Console.WriteLine($"The {MainColor} Cessna carefully turns {direction}.");
        }
        public void Stop() 
        {
            Console.WriteLine($"The {MainColor} Cessna rolls down the runway for a mile and stops.");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane, Zzzzoooooommmm!");
        }
    }
}