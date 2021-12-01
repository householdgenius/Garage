namespace Garage{
public interface IElectricVehicles
{
   double BatteryKWh { get; set; } 
   int CurrentChargePercentage {get; set;}
   void ChargeBattery();
   void Drive();
   void Turn();
   void Stop();
}
public interface IGasVehicles 
{
    double FuelCapacity { get; set; }
    int CurrentTankPercentage {get; set;}

    void RefuelTank();
    void Drive();
   void Turn();
   void Stop();
}
}