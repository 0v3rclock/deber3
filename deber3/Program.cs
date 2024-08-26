using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deber3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Menú de opciones");
                Console.WriteLine("1. Realizar una operación matemática");
                Console.WriteLine("2. Mostrar un mensaje");
                Console.WriteLine("3. Salir del programa");
                Console.Write("Ingrese su opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RealizarOperacionMatematica();
                        break;
                    case 2:
                        MostrarMensaje();
                        break;
                    case 3:
                        Console.WriteLine("Adiós!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 3);
        }

        static void RealizarOperacionMatematica()
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la operación (+, -, *, /): ");
            string operacion = Console.ReadLine();

            int resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: no se puede dividir entre cero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operación inválida.");
                    return;
            }

            Console.WriteLine("El resultado es: " + resultado);
        }

        static void MostrarMensaje()
        {
            Console.WriteLine("¡Hola! Este es un mensaje para ti.");
            
        }
        
    }
}

