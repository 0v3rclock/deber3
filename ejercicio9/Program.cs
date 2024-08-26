using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] productos = { "Coca-Cola", "Fanta", "Sprite", "Agua" };
            decimal[] precios = { 1.50m, 1.25m, 1.00m, 0.75m };

            Console.WriteLine("Máquina Expendedora");
            Console.WriteLine("------------------");

            // Mostrar productos y precios
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {productos[i]} - ${precios[i]:F2}");
            }

            Console.Write("Seleccione un producto (1-{0}): ", productos.Length);
            int seleccion = Convert.ToInt32(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    // Verificar pago
                    Console.Write("Ingrese el dinero: $");
                    decimal pago = Convert.ToDecimal(Console.ReadLine());

                    if (pago >= precios[seleccion - 1])
                    {
                        // Entregar producto
                        Console.WriteLine($"Dispensando {productos[seleccion - 1]}...");
                        Console.WriteLine("Gracias por su compra!");
                        if (pago > precios[seleccion - 1])
                        {
                            Console.WriteLine($"Su cambio es: ${pago - precios[seleccion - 1]:F2}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No tiene suficiente dinero. Intente de nuevo.");
                    }
                    break;
                default:
                    Console.WriteLine("Selección inválida. Intente de nuevo.");
                    break;
            }
        }
    }
}
