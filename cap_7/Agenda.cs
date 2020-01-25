using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulos_5_6_7_8.cap_7
{
    public class Agenda
    {
        
        public void Guardar()
        {
            Hashtable telefono = new Hashtable();
            int op;
            string nombre, numero;

            do
            {
                Console.Clear();
                Console.WriteLine("1- Agregar contacto.");
                Console.WriteLine("2- Buscar contacto.");
                Console.WriteLine("3- Salir.");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("Ingrese nombre ");
                        nombre = Console.ReadLine();
                        Console.Write("Ingrese numero ");
                        numero = Console.ReadLine();

                        telefono.Add(nombre, numero);
                        break;

                    case 2:
                        bool existe = false;

                        Console.Write("Ingrese Contacto a buscar ");
                        nombre = Console.ReadLine();

                        foreach (DictionaryEntry dato in telefono)
                        {
                            if (Convert.ToString(dato.Key) == nombre)
                                existe = true;
                        }

                        if (existe == true)
                        {
                            Console.WriteLine("Nombre: {0}", nombre);
                            Console.Write("Numero Telefonico: ");
                            Console.WriteLine(telefono[nombre]);
                        }
                        else
                        {
                            Console.WriteLine("Contacto no encontrado");
                        }

                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("ERROR, contacto no valido");
                        Console.ReadKey();
                        break;
                }
            } while (op != 3);
        }
    }
}