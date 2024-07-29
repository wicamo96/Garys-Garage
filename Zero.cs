using System;

namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {

        }
        public void Turn(string direction) 
        {
            Console.WriteLine($"The {MainColor} Zero carefully turns {direction}.");
        }
        public void Stop() 
        {
            Console.WriteLine($"The {MainColor} Zero gently rolls to a stop.");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you, Yeeeeeeeeeeooooooowww!");
        }
    }
}