using System;
namespace Garage
{
    class Zero : Vehicle, IElectricVehicles  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage {get; set;}
        public void ChargeBattery()
        {
           CurrentChargePercentage = 100;
        }
         public override void Drive()
        {
            Console.WriteLine("The Zebra Striped Zero zips past. Zoooooom!");
        }
         public override void Turn()
        {
            Console.WriteLine("The Zero eases into a right turn on the racetrack");
        }
         public override void Stop()
        {
            Console.WriteLine("The Zebra Zero rolls to a stop after rolling past the finish line and winning the race.");
        }
    }
}
