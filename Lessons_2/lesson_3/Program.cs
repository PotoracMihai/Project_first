using System;
using System.IO;
namespace lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars auto = new Cars { };


            Console.WriteLine("                                                                                         ");
            Console.WriteLine("*******************************" + "      Your chosen filtres        " + "*************************");
            Console.WriteLine("The color is: " + auto.color);
            Console.WriteLine("The model is: " + auto.model);
            Console.WriteLine("The category is: " + auto.category);
            Console.WriteLine("The type of body is: " + auto.body);
            Console.WriteLine("The number of seats is: " + auto.seats);
            Console.WriteLine("The price of the car is: " + auto.price + "$");

        }
    }
    class Cars
    {
        public string color ;
        public string model;
        public char category;
        public string  body;
        public int seats;
        public int price;

        public Cars()
        {
            
            Console.WriteLine("Enter a color for you car (red, blue, green, yellow, black, white, gray, brown): ");
            color = Console.ReadLine();
           // File.WriteAllText("output.txt",color);
        
            Console.WriteLine("Enter a model for you car (sedan, hack back, crossover, AWD): ");
            model = Console.ReadLine();
           // File.WriteAllText("output.txt", model);

            Console.WriteLine("Enter a categori for you car (A, B, C, D): ");
            category = Convert.ToChar(Console.ReadLine());
            //File.WriteAllText("output.txt", category);

            Console.WriteLine("Enter a type of body for you car (long or short): ");
            body = Console.ReadLine();
           // File.WriteAllText("output.txt", body);

            Console.WriteLine("Enter a number of seats (2, 4, 5, 7): ");
            seats = Convert.ToInt32(Console.ReadLine());
           // File.WriteAllText("output.txt", seats);

            Console.WriteLine("Enter a price do you want (3000$ up to 50000$): ");
            price = Convert.ToInt32(Console.ReadLine());
               
                if (price > 3000 &&  price < 50000 )
                {
                    Console.WriteLine("The price is corect !!!");
                }
                else
                {
                    Console.WriteLine("The price is lower or to bigger ");
                
                }
            }
        

    }
}
