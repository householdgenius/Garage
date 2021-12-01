using System;
namespace Garage
{
     class Cessna : Vehicle, IGasVehicles
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage {get; set;}
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine("The cool cardial Cessna zips by. Zoooooom!");
        }
        public override void Turn()
        {
            Console.WriteLine("The Cessna eases into a left turn on the runway");
        }
         public override void Stop()
        {
            Console.WriteLine("The cardinal Cessna rolls to a stop after rolling a mile down the runway");
        }
    }
}
