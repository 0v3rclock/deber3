using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static decimal saldo = 1000.00m; // saldo inicial

        static void Main()
        {
            Console.WriteLine("Bienvenido al cajero automático");

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Retirar dinero");
                Console.WriteLine("2. Ver saldo");
                Console.WriteLine("3. Salir");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RetirarDinero();
                        break;
                    case 2:
                        VerSaldo();
                        break;
                    case 3:
                        Salir();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void RetirarDinero()
        {
            Console.Write("Ingrese la cantidad de dinero que desea retirar: ");
            decimal cantidad = Convert.ToDecimal(Console.ReadLine());

            if (cantidad > saldo)
            {
                Console.WriteLine("No tiene saldo suficiente.");
            }
            else
            {
                saldo -= cantidad;
                Console.WriteLine("Retiro exitoso. Su nuevo saldo es: " + saldo);
            }
        }

        static void VerSaldo()
        {
            Console.WriteLine("Su saldo actual es: " + saldo);
        }

        static void Salir()
        {
            Console.WriteLine("Gracias por utilizar el cajero automático.");
            Environment.Exit(0);
        }
    }
}
