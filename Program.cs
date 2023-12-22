using Patterns.Models;
using Patterns.Models.Base;
using Patterns.Services;
using Patterns.Services.Base;

FactoryMethodBase factoryMethod = new MyVehicleCreator();

IVehicle myVehicle = factoryMethod.Create(VehicleType.Truck);

System.Console.WriteLine(myVehicle.Deliver());