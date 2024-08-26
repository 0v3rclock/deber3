using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud del lado 1: ");
            int lado1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la longitud del lado 2: ");
            int lado2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la longitud del lado 3: ");
            int lado3 = Convert.ToInt32(Console.ReadLine());

            string tipoTriangulo = ClasificarTriangulo(lado1, lado2, lado3);

            Console.WriteLine("El triángulo es " + tipoTriangulo);
        }

        static string ClasificarTriangulo(int lado1, int lado2, int lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "equilátero";
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                return "isósceles";
            }
            else
            {
                return "escaleno";
            }
  
        }
    }
}
