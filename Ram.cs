using System;
namespace Garage
{
   class Ram : Vehicle, IGasVehicles // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage {get; set;}
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
         public override void Drive()
        {
            Console.WriteLine("The rad red ram drives past. Vroooooom!");
        }
         public override void Turn()
        {
            Console.WriteLine("The Ram rushes into a left turn on the highway");
        }
         public override void Stop()
        {
            Console.WriteLine("The red ram rolls to a stop after rolling a mile down the highway");
        }
    }
}