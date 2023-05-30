using System.Buffers.Text;
using System.ComponentModel;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = VehicleFactory.GetTire("four");

            car.Drive();
       
        }
    }
}
