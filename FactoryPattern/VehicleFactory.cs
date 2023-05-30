using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetTire(string wheels) 
        { 
            switch(wheels.ToLower()) 
            {
                case "four":
                    return new Car();
                case "two":
                    return new Motorcycle();
                default:
                    return new Car();
                     
            }
        }
    }
}
