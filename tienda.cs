using System;

namespace ENRIQUEEEEE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] ventas = { 200000.0, 302300.0, 300233.0, 700000.0, 740432.0, 100233.0, 823231.0, 902211.0 };
            double total = 0;
            double mayorventa = ventas[0];
            double menorventa = ventas[0];
            int diamayorventa = 0;
            int diamenorventa = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                total += ventas[i];
                if (ventas[i] > mayorventa)
                {
                    mayorventa = ventas[i];
                    diamayorventa = i;
                }

                if (ventas[i] < menorventa)
                {
                    menorventa = ventas[i];
                    diamenorventa = i;
                }
            }

            double promedio = total / ventas.Length;
            int diasobrepromedio = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i] > promedio)
                {
                    diasobrepromedio++;
                }
            }

            Console.WriteLine("========= Reporte de ventas =========");
            Console.WriteLine();

            Console.WriteLine($"Total vendido: ${total:F2}");
            Console.WriteLine($"Promedio diario: ${promedio:F2}");
            Console.WriteLine();

            Console.WriteLine($"Mayor venta: ${mayorventa:F2} - El día {diamayorventa + 1}");
            Console.WriteLine($"Menor venta: ${menorventa:F2} - El día {diamenorventa + 1}");
            Console.WriteLine($"Días que superaron el promedio de ventas: {diasobrepromedio}");
            Console.WriteLine();

            Console.WriteLine("Ventas por días:");
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine($"Día {i + 1}: ${ventas[i]:F2}");
            }
        }
    }
}
