using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] codigos = { 135, 247, 389, 412, 526, 638, 741, 853, 964, 176,
                              285, 394, 507, 619, 728, 836, 945, 153, 267, 478 };

            Console.WriteLine($"codigos actuales: {string.Join(",", codigos)}");

            Console.WriteLine("Ingrese el codigo que desea actualizar: ");
            int busqueda = Convert.ToInt32(Console.ReadLine());

            int indiceEncontrado = -1;

            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda)
                {
                    indiceEncontrado = i;
                    break;
                }
            }

            if (indiceEncontrado != -1)
            {
                Console.WriteLine("Ingrese el nuevo codigo: ");
                codigos[indiceEncontrado] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nVector actualizado: {string.Join(",", codigos)}");
            }
            else
            {
                Console.WriteLine("\nError: el codigo ingresado no existe en la BDD");
            }
        }
    }
}
