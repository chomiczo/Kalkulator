using System;
namespace Kalkulator
{
    public class Kalkulator
    {
        public static double Dodawanie(double x, double y)
        {
            return x + y;
        }
        public static double Odejmowanie(double x, double y)
        {
            return x - y;
        }
        public static double Mnożenie(double x, double y)
        {
            return x * y;
        }
        public static double Dzielenie(double x, double y)
        {
            if(y == 0)
            {
                Console.WriteLine("Nie można dzielić przez zero!");
            }
                return x / y;

        }
        public static double Potęgowanie(double x, double y)
        {
            return Math.Pow(x, y);
        }
        public static double Pierwiastkowanie(double x, double y)
        {
            if(x < 0 && y %2 == 0)
            {
                Console.WriteLine("Nie można pierwiastkować liczby ujemnej przez parzysty stopień.");
            }

                return Math.Pow(x , 1 / y);
            
        }
        static void Main(string[] args)
        {
            //Dodawanie(3, 5);
            //Odejmowanie(3, 5);
            //Mnożenie(3, 5);
            //Dzielenie(3, 5);
            //Potęgowanie(3, 5);
            //Pierwiastkowanie(3, 5);
            Console.WriteLine("Hello World!");

        }
    }
}