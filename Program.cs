using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleFunc doubleMax = Max;
            DoubleFunc doubleMin = Min;


            double first = InputDouble("Введите первое вещественное число: ");
            double second = InputDouble("Введите второе вещественное число: ");

            Console.WriteLine($"\nМаксимальное число: {doubleMax(first, second)}");
            Console.WriteLine($"Минимальное число: {doubleMin(first, second)}");

            Console.ReadKey(true);
        }

        delegate double DoubleFunc(double first, double second);

        static double Max(double first, double second)
        {
            return first > second ? first : second;
        }

        static double Min(double first, double second)
        {
            return first < second ? first : second;
        }

        static double InputDouble(string message)
        {
            double newDouble;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out newDouble))
            {
                Console.WriteLine("Нельзя преобразовать в тип double!");
                Console.Write(message);
            }
            return newDouble;
        }
    }
}
