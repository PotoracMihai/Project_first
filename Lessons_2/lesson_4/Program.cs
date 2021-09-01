using System;
using System.Collections.Generic;
using lesson_5.Model;
using lesson_5;

namespace lesson_4
{
    class Program
    {
        private static List<Car> list = new List<Car>();
        static void Main(string[] args)
        {
            var service = new CarsServices();
            for(; ; )
            {
                string input = PrintMenuAndRead();
                switch (input)
                {
                    case "1":
                        {
                            service.AddNewCar(list);
                        }
                        break;
                    case "2":
                        {
                            service.PrintAllCars();
                        }
                        break;
                    case "3":
                        {
                            service.RemoveCarsByModel();
                        }
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }

            }
        }

        private static void RemoveCarsByModel()
        {
            Console.WriteLine("Enter a model of the car to remove: ");
            var nameToRemove = Console.ReadLine();
            Car s1 = default;

            foreach (var car in list)
            {
                if(car.Model_car == nameToRemove)
                {
                    s1 = car;
                }
            }
            list.Remove(s1);
        }

        private static string PrintMenuAndRead()
        {
            Console.WriteLine("Meniu: ");
            Console.WriteLine("-> 1 - Add new model of car: ");
            Console.WriteLine("-> 2 - Print all cars to console: ");
            Console.WriteLine("-> 3 - Remove car by model: ");
            Console.WriteLine("-> 4 - Exit");
            var input = Console.ReadLine();
            return input;
        }

        static void AddNewCar(List<Car> list)
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
        private static void PrintAllCars()
        {
            foreach (var car in list)
            {
                Console.WriteLine(car.GetFullName());
            }
        }
    }
}
