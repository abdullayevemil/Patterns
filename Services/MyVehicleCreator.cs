using Patterns.Models;
using Patterns.Models.Base;
using Patterns.Services.Base;

namespace Patterns.Services;
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
