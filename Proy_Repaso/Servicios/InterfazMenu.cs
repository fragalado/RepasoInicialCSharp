using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Repaso.Servicios
{
    /**
     * Interfaz que define los métodos que darán servicio a Menu
     */
    internal interface InterfazMenu
    {

        /**
         * Método que muestra por pantalla un menu y devuelve la opción elegida
         */
        int Menu();
    }
}