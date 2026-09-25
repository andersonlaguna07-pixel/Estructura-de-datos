using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaiderman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[5];
            Console.WriteLine("----Ingreso de temperaturas----");

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.WriteLine($"ingrese la temperatura del dia {i + 1}");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            } 
            double suma = 0;
            double maxT = temperaturas[0];
            double minT = temperaturas[0];

            foreach (double temp in temperaturas)
            {
                if (temp > maxT);
                if (temp < minT);
            }

            double promedio = suma / maxT;

            Console.WriteLine("\n---Reporte---");
            Console.WriteLine($"Temperatura registradas: {String.Join(",", temperaturas)}");
            Console.WriteLine($"Temperaturas promedio: {promedio:F2}°C");
            Console.WriteLine($"Temperaturas maxima: {maxT}°C");
            Console.WriteLine($"Temperaturas minimas: {minT}°C");
        }   
    }
}
