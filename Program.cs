using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Car> cars = new List<Car>();
            cars.Add(new Car());
            cars.Add(new Car("Ford"));
            cars.Add(new Car());
            cars.Add(new Car("Mersedes", 1.3, "white", 23000000, 2020));
            cars.Add(new Car("Toyota"));
            Console.WriteLine(Car.count);
            cars[3].GetInfo();
            cars[3].Reset();
            cars[3].GetInfo();
            Console.WriteLine(Car.count);

        }
    }
}
