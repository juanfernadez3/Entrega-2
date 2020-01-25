using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulos_5_6_7_8.cap_8
{
    public class Fecha_hora
    {
        public void MostrarFechaHora()
        {
            String Fecha_Hora = string.Format("{0:hh:mm:ss tt\nyyyy/dd/MM}", DateTime.Now);
            Console.WriteLine("{0}", Fecha_Hora);
            Console.ReadKey();
        }
    }
}