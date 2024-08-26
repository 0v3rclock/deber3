using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Ingrese la cantidad de unidades del producto: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                decimal precioUnitario = 10.00m; // precio unitario del producto
                decimal precioFinal = 0.00m;

                switch (cantidad)
                {
                    case int n when n >= 1 && n <= 9:
                        precioFinal = cantidad * precioUnitario;
                        break;
                    case int n when n >= 10 && n <= 49:
                        precioFinal = cantidad * precioUnitario * 0.95m; // 5% de descuento
                        break;
                    case int n when n >= 50 && n <= 99:
                        precioFinal = cantidad * precioUnitario * 0.90m; // 10% de descuento
                        break;
                    case int n when n >= 100:
                        precioFinal = cantidad * precioUnitario * 0.85m; // 15% de descuento
                        break;
                    default:
                        Console.WriteLine("Cantidad inválida.");
                        return;
                }

                Console.WriteLine($"Precio final: {precioFinal:C2}");
            }
    }
}
