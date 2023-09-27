using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Repaso.Servicios
{
    /**
     * Interfaz que define los métodos que darán servicio a Ficheros
     */
    interface InterfazFicheros
    {
        /**
         * Método que escribirá en el fichero pasado por parámetros los valores de la lista separados por ';'
         * Tambien escribira el titulo: ID; NOMBRE; APELLIDOS; DNI; FECHANAC; TITULACION MAS ALTA
         * EJ: Fran;Gallego;Dorado;
         * Este método va a sobreescribir el fichero
         */
        void EscribirFichero(List<Empleado> listaBD, string ruta);
    }
}