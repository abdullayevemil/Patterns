using Patterns.Models.Base;

namespace Patterns.Models;
public class Ship : IVehicle
{
    public string Deliver()
    {
        return "Delivered by ship";
    }
}
