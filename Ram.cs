using System;
namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
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