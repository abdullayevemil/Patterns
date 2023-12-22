FactoryMethodBase factoryMethod = new MyVehicleCreator();

IVehicle myVehicle = factoryMethod.Create(VehicleType.Truck);

System.Console.WriteLine(myVehicle.Deliver());


public enum VehicleType 
{
    Truck,
    Ship
}

public interface IVehicle
{
    string Deliver();
}

public class Truck : IVehicle
{
    public string Deliver()
    {
        return "Delivered by truck";
    }
}

public class Ship : IVehicle
{
    public string Deliver()
    {
        return "Delivered by ship";
    }
}

public abstract class FactoryMethodBase
{
    public abstract IVehicle Create(VehicleType vehicleType);
}

public class MyVehicleCreator : FactoryMethodBase
{
    public override IVehicle Create(VehicleType vehicleType)
    {
        return vehicleType switch
        {
            VehicleType.Truck => new Truck(),
            VehicleType.Ship => new Ship(),
            _ => throw new Exception()
        };
    }
}