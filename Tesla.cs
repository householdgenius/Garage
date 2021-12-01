using System;
namespace Garage
{
     class Tesla : Vehicle, IElectricVehicles
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage {get; set;} 
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine("The teeming teal tesla drives past. Troooooom!");
        }
         public override void Turn()
        {
            Console.WriteLine("The Tesla eases into a driveway");
        }
         public override void Stop()
        {
            Console.WriteLine("The teal tesla rolls to a stop after rolling up to the mansion.");
        }
    }
}
