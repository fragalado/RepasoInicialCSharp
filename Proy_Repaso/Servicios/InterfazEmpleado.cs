using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Repaso
{
    /**
     * Interfaz que define los métodos que darán servicio a Empleados
     */
    interface InterfazEmpleado
    {
        /**
         * Método que registra un empleado con los datos introducidos por consola.
         * Pide los datos, crea un objeto de tipo Empleado y lo añade a la lista dada por parámetros
         * Devuelve la lista actualizada
         */
        List<Empleado> RegistraEmpleado(List<Empleado> listaBD);

        /**
         * Método que modifica un empleado según su ID.
         * Pide el id del usuario y después pregunta que se quiere modificar
         * Devuelve la lista actualizada
         */
        List<Empleado> ModificaEmpleado(List<Empleado> listaBD);

        /**
         * Método que exportará a un fichero todos los empleados o un empleado según su ID
         * Se exportará toda la información excepto el numero de Seguridad Social y el numero de cuenta
         */
        void ExportarEmpleado(List<Empleado> listaBD);
    }
}