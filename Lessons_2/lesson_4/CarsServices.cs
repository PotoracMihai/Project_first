using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson_5.Model;

namespace lesson_5
{

    public class CarsServices
    {
        private static List<Car> list = new List<Car>();
        public CarsServices()
        {
        }
        public void PrintAllCars()
        {
            foreach (var car in list)
            {
                Console.WriteLine(car.GetFullName());
            }
        }

        public void AddNewCar(List<Car> list)
        {
            Console.WriteLine("Enter a model of the car: ");
            var Model_car = Console.ReadLine();
            Console.WriteLine("Enter a mark of the car: ");
            var Mark_car = Console.ReadLine();

            var auto = new Car
            {
                Model_car = Model_car,
                Mark_car = Mark_car,
                Registered = DateTime.Now
            };
            list.Add(auto);
        }

        public void RemoveCarsByModel()
        {
            Console.WriteLine("Enter a model of the car to remove: ");
            var nameToRemove = Console.ReadLine();
            Car s1 = default;

            foreach (var car in list)
            {
                if (car.Model_car == nameToRemove)
                {
                    s1 = car;
                }
            }
            list.Remove(s1);
        }
    }
}