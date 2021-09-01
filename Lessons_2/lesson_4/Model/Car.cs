using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace lesson_5.Model
{
    /// <summary>
    /// This class is used to store data
    /// about Car:
    ///     fields:
    ///         Model_car
    ///         Mark_car
    ///         registred date
    ///     function:
    ///         get full name
    ///         get registred days
    ///     
    /// </summary>
   public class Car
    {
        public string Model_car;
        public string Mark_car;
        public DateTime Registered;


        public Car()
        {
        }

       
        public string GetFullName()
        {
            return Model_car + " " + Mark_car;
        }

    }
}
