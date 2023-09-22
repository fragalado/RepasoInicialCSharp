using Proy_Repaso.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista donde guardaremos los objetos de tipo Empleado
            List<Empleado> listaBD = new List<Empleado>();

            // Inicializamos la interfaz menu y empleado
            InterfazMenu intM = new ImplMenu();
            InterfazEmpleado intE = new ImplEmpleado();

            // Mostramos el menu
            int opcion;
            do
            {
                Console.Clear(); // Limpiamos la pantalla
                opcion = intM.Menu();

                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        // Registro empleado
                        try
                        {
                            intE.RegistraEmpleado(listaBD);
                        } catch (Exception e)
                        {
                            Console.WriteLine("\n\t** Error: No se ha podido registrar empleado **");
                        }
                        break;
                    case 2:
                        // Modifica empleado
                        try
                        {
                            intE.ModificaEmpleado(listaBD);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n\t** Error: No se ha podido modificar el empleado **");
                        }
                        break;
                    case 3:
                        // Exportar empleado/s
                        Console.WriteLine("Exportar empleado");
                        break;
                }

                // para volver al menu
                if(opcion != 0)
                {
                    Console.WriteLine("\n\t\t\tPulse una tecla para volver al menu");
                    Console.ReadKey(true);
                }
            } while (opcion != 0);

            // Para salir
            Console.WriteLine("\n\n\n\tPulse una tecla para salir");
            Console.ReadKey(true);
        }
    }
}
