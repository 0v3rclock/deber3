using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número que represente un día de la semana (1-7): ");
            int dia = Convert.ToInt32(Console.ReadLine());

            string nombreDia = ObtenerNombreDia(dia);

            Console.WriteLine("El día correspondiente es: " + nombreDia);
        }

        static string ObtenerNombreDia(int dia)
        {
            switch (dia)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miércoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sábado";
                case 7:
                    return "Domingo";
                default:
                    return "Número inválido";
            }
        }
    }
}
