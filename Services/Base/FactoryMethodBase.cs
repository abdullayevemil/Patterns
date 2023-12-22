using Patterns.Models;
using Patterns.Models.Base;

namespace Patterns.Services.Base;
public abstract class FactoryMethodBase
{
    public abstract IVehicle Create(VehicleType vehicleType);
}