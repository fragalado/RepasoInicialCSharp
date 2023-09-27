using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Repaso.Servicios
{
    /**
     * Implementación de la interfaz Menu
     */
    class ImplMenu : InterfazMenu
    {
        public int Menu()
        {
            int opcion;
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
                opcion = Console.ReadKey().KeyChar - '0';

                if (opcion < 0 || opcion > 3) Console.Clear(); // Para limpiar la consola
                if(opcion < 0 || opcion > 3)
                    Console.WriteLine("\n\t\t\t** Error: El valor no está dentro del rango **");
            } 
            while (opcion < 0 || opcion > 3);
            
            return opcion;
        }
    }
}