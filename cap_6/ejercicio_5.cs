using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulos_5_6_7_8.cap_6
{
    public class ejercicio_5
    {
        public void Metodo()
        {
            int[][] arreglo = new int[3][];

            arreglo[0] = new int[] { 1, 2, 3 };
            arreglo[1] = new int[] { 4, 5, 6 };
            arreglo[2] = new int[] { 7, 8, 9 };

            MostrarArregloJagged(arreglo);
        }

        public void MostrarArregloJagged(int[][] arreglo)
        {
            Console.WriteLine("--- Arreglo Jagged ---");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arreglo[i].GetLength(0); j++)
                {
                    Console.Write("{0} ", arreglo[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }


    }
}