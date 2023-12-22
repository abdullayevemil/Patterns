using Patterns.Models.Base;

namespace Patterns.Models;
public class Truck : IVehicle
{
    public string Deliver()
    {
        return "Delivered by truck";
    }
}
