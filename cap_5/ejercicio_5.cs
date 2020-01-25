using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulos_5_6_7_8.cap_5
{
       public class ejercicio_5
    {
        public void PedirDatos()
        {
            int numero;
            string palabra;

            Console.Write("Ingrese un numero del 0 al 20: ");
            numero = Convert.ToInt32(Console.ReadLine());

            palabra = convertir(numero);

            Console.WriteLine("{0}", palabra);
            Console.ReadKey();
        }

        public string convertir(int n)
        {
            switch (n)
            {
                case 0:
                    return "Cero";

                case 1:
                    return "Uno";

                case 2:
                    return "Dos";

                case 3:
                    return "Tres";

                case 4:
                    return "Cuatro";

                case 5:
                    return "Cinco";

                case 6:
                    return "Seis";

                case 7:
                    return "Siete";

                case 8:
                    return "Ocho";

                case 9:
                    return "Nueve";

                case 10:
                    return "Diez";

                case 11:
                    return "Once";
                case 12:
                    return "Doce";
                case 13:
                    return "Trece";
                case 14:
                    return "Catorce";
                case 15:
                    return "Quince";
                case 16:
                    return "Dieciseis";
                case 17:
                    return "Dieciciete";
                case 18:
                    return "Dieciocho";
                case 19:
                    return "Diecinueve";
                case 20:
                    return "Veinte";

                default:
                    return "ERROR 102: El numero que digito es invalido...";
            }
        }
    }
}