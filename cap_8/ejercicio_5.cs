using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulos_5_6_7_8.cap_8
{
    class ejercicio_5
    {
        public void Metodo()
        {
            string cad1, cad2;
            Console.WriteLine("Ingrese cadena #1 : ");
            cad1 = Console.ReadLine();
            Console.WriteLine("Ingrese cadena #2 : ");
            cad2 = Console.ReadLine();

            if (cad1.CompareTo(cad2) == 0)
                Console.WriteLine("Cadena #1: {0}\nCadena 2: {1}", cad1, cad2);
            else if (cad1.CompareTo(cad2) > 0)
                Console.WriteLine("Cadena #2: {0}\nCadena 1: {1}", cad2, cad1);
            else
                Console.WriteLine("Cadena #1: {0}\nCadena 2: {1}", cad1, cad2);

            Console.ReadKey();
        }
    }
}
