using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Repaso.Servicios
{
    internal class ImplMenu : InterfazMenu
    {
        public int Menu()
        {
            int opcion;
            bool ok;
            do {
                Console.WriteLine("\n\n\t\t\t╔════════════════════════════╗");
                Console.WriteLine("\t\t\t║   1) Registro empleado     ║");
                Console.WriteLine("\t\t\t║   2) Modifica empleado     ║");
                Console.WriteLine("\t\t\t║   3) Exportar fichero      ║");
                Console.WriteLine("\t\t\t║                            ║");
                Console.WriteLine("\t\t\t║   0) Salir                 ║");
                Console.WriteLine("\t\t\t║                            ║");
                Console.WriteLine("\t\t\t╚════════════════════════════╝");
                Console.Write("\t\t\tIntroduzca una opción: ");
                ok = Int32.TryParse(Console.ReadLine(), out opcion);

                if (!ok || opcion < 0 || opcion > 3) Console.Clear(); // Para limpiar la consola
                if(!ok)
                    Console.WriteLine("\n\t\t\t** Error: No se ha introducido el formato correcto **");
                else if(opcion < 0 || opcion > 3)
                    Console.WriteLine("\n\t\t\t** Error: El valor no está dentro del rango **");
            } 
            while (!ok || opcion < 0 || opcion > 3);
            
            return opcion;
        }
    }
}
