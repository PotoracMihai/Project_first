using System;

namespace Lessons_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string First_name = Console.ReadLine();

            Console.WriteLine("Enter your second name: ");
            string Second_name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            char a = 'a', b ='b',c='c',d='d';
            string hoby = "gaming";

            Console.WriteLine(                                                                                       );

            Console.WriteLine("             About me: ");
            Console.WriteLine("                    "+ a +")" + " My first name is: " + First_name + ";");
            Console.WriteLine("                    " + b +")" + " My second name is: " + Second_name + ";");
            Console.WriteLine("                    " + c +")" + " My age is: " + age+";");
            Console.WriteLine("                    " + d +")" + " I love to "+hoby+" on PC"+";");
            Console.WriteLine(                                                                                        );

            Console.WriteLine("Enter a first number");
            double first_num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            double second_num = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine( "Sum of two number "+ first_num + second_num);

        }
    }
}
