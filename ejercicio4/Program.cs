using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la calificación numérica del estudiante (0-100): ");
            int calificacion = Convert.ToInt32(Console.ReadLine());

            string letraCalificacion = ObtenerLetraCalificacion(calificacion);

            Console.WriteLine("La calificación es: " + letraCalificacion);
        }

        static string ObtenerLetraCalificacion(int calificacion)
        {
            switch (calificacion / 10)
            {
                case 10:
                case 9:
                    return "A";
                case 8:
                    return "B";
                case 7:
                    return "C";
                case 6:
                    return "D";
                default:
                    return "F";
            }
        }
    }
}
