using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArreglos2
{
    internal class Metodos
    {
        public void SumarArreglos()
        {
            int[]a = new int[5];
            int[]b = new int[5];
            int[]c = new int[5];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Ingresa los primeros numeros");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int z = 0; z < b.Length; z++)
            {
                Console.WriteLine("Ingresa los segundos numeros");
                b[z] = Convert.ToInt32(Console.ReadLine());
            }
            for (int x = 0; x < c.Length; x++)
            {
                c[x] = a[x] + b[x];
            }

            for (int y = 0; y < c.Length; y++)
            {
                Console.WriteLine($"La suma numero {y+1} es igual a {c[y]}");
            }
        }



    }
}
