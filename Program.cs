using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero S = new Zero() {
                MainColor = "Red",
                MaximumOccupancy = 2,
                BatteryKWh = 14.4
            };

            Tesla ModelS = new Tesla() {
                MainColor = "Midnight Blue",
                MaximumOccupancy = 5,
                BatteryKWh = 100
            };

            Cessna Citation = new Cessna() {
                MainColor = "White",
                MaximumOccupancy = 12,
                FuelCapacity = 742
            };

            Ram Dodge = new Ram() {
                MainColor = "Purple",
                MaximumOccupancy = 5,
                FuelCapacity = 26
            };
        
        
            S.Drive();
            S.Turn("left");
            S.Stop();

            Console.WriteLine("");

            ModelS.Drive();
            ModelS.Turn("right");
            ModelS.Stop();

            Console.WriteLine("");
            
            Citation.Drive();
            Citation.Turn("left");
            Citation.Stop();

            Console.WriteLine("");

            Dodge.Drive();
            Dodge.Turn("right");
            Dodge.Stop();
        }
    }
}