using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Repaso.Servicios
{
    /**
     * Implementacion de la interfaz ficheros
     */
    class ImplFicheros : InterfazFicheros
    {
        public void EscribirFichero(List<Empleado> listaBD, string ruta)
        {
            // StreamWriter para escribir en el fichero
            StreamWriter sw = File.CreateText(ruta);

            // Ahora escribimos la cabecera:
            // ID; NOMBRE; APELLIDOS; DNI; FECHANAC; TITULACION MAS ALTA
            sw.WriteLine("ID; NOMBRE; APELLIDOS; DNI; FECHANAC; TITULACION MAS ALTA");

            // Ahora recorremos la lista y escribimos en el fichero los datos
            foreach (Empleado aux in listaBD)
            {
                sw.WriteLine("{0}; {1}; {2}; {3}; {4}; {5};", aux.Id
                                                            , aux.Nombre
                                                            , aux.Apellidos
                                                            , aux.Dni
                                                            , aux.FechaNac
                                                            , aux.TitulacionMasAlta);
            }

            // Cerramos el StreamWriter
            sw.Close();
        }
    }
}