using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
             Ram R1500 = new Ram();
            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            Console.WriteLine(" ");
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            Console.WriteLine(" ");
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            Console.WriteLine(" ");
            R1500.Drive();
            R1500.Turn();
            R1500.Stop();
        }
    }
}
