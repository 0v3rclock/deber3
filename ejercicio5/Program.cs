using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre de una fruta: ");
            string fruta = Console.ReadLine();

            bool esCitrica = EsFrutaCitrica(fruta);

            if (esCitrica)
            {
                Console.WriteLine("La fruta " + fruta + " es cítrica.");
            }
            else
            {
                Console.WriteLine("La fruta " + fruta + " no es cítrica.");
            }
        }

        static bool EsFrutaCitrica(string fruta)
        {
            switch (fruta.ToLower())
            {
                case "naranja":
                case "limón":
                case "lima":
                case "mandarina":
                case "pomelo":
                    return true;
                default:
                    return false;
            }
        }
    }
}
