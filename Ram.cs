using System;

namespace Garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {

        }
        public void Turn(string direction) 
        {
            Console.WriteLine($"The {MainColor} Ram carefully turns {direction}.");
        }
        public void Stop() 
        {
            Console.WriteLine($"The {MainColor} Ram gently rolls to a stop.");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past, RRRuuuuummmmmbbblllee!");
        }
    }
}