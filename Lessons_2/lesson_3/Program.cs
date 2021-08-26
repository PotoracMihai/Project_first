using System;
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
        
            Console.WriteLine("Enter a model for you car (sedan, hack back, crossover, AWD): ");
            model = Console.ReadLine();

            Console.WriteLine("Enter a categori for you car (A, B, C, D): ");
            category = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter a type of body for you car (long or short): ");
            body = Console.ReadLine();

            Console.WriteLine("Enter a number of seats (2, 4, 5, 7): ");
            seats = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a price do you want (3000$ up to 50000$): ");
            price = Convert.ToInt32(Console.ReadLine());

               
                if (price >= 3000 &&  price <= 50000 )
                {
                    Console.WriteLine("The price is corect !!!");
                }
                else
                {
                    Console.WriteLine("The price is lower or to bigger ");
                
                }


            if (seats == 2)
            {
                Console.WriteLine("Corect number of the seats: " + seats);
            }
            else if(seats == 4)
            {
                Console.WriteLine("Corect number of the seats: " + seats);
            }
            else if (seats == 5)
            {
                Console.WriteLine("Corect number of the seats: " + seats);
            }else if(seats == 7)
            {
                Console.WriteLine("Corect number of the seats: " + seats);
            }
            else
            {
                Console.WriteLine("The number of seats is incorect !!!");
            }

            if (category == 'A')
            {
                Console.WriteLine("Corect category !"+ " "+category);
            }else if (category == 'B')
            {
                Console.WriteLine("Corect category !" + " " + category);
            }else if(category == 'C')
            {
                Console.WriteLine("Corect category !" + " " + category);
            }else if (category == 'D')
            {
                Console.WriteLine("Corect category !" + " " + category);
            }
            else
            {
                Console.WriteLine("Incorect category !!!");
            }
            }
        

    }
}
