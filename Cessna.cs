using System;
namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
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
