using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            switch (edad)
            {
                case int n when n >= 18:
                    Console.WriteLine("Usted tiene la edad suficiente para votar.");
                    break;
                default:
                    Console.WriteLine("Usted no tiene la edad suficiente para votar.");
                    break;
            }
        }
    }
}
