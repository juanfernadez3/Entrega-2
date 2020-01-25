using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulos_5_6_7_8.cap_5
{
    public class Ejercicio_4
    {
        public void PedirDatos()
        {
            int numero = 0;

            Console.Write("Ingrese numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            CalcularFactorial(numero);
            Console.ReadKey();
        }

        public void CalcularFactorial(int n)
        {
            int r = 1;

            if (n >= 0)
            {
                for (int i = 0; i < n; i++)
                {
                    r = r * (n - i);
                }
                Console.WriteLine("El factorial de {0} es {1}", n, r);
            }
            else
            {
                Console.WriteLine("ERROR Numero No Valido");
            }
        }
    }
}
