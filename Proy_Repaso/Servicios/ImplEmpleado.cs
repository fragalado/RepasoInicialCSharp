using Proy_Repaso.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Repaso
{
    /**
     * Implementación de la interfaz empleado
     */
    class ImplEmpleado : InterfazEmpleado
    {
        public List<Empleado> RegistraEmpleado(List<Empleado> listaBD)
        {
            // nombre, apellidos, dni, fechaNac, titulacionMasAlta, numSegSoc, numCuenta

            // Declaramos un objeto de tipo Empleado
            Empleado e = new Empleado();

            // Pedimos el nombre
            Console.Write("\n\n\tIntroduce el nombre: ");
            e.Nombre = Console.ReadLine();

            // Pedimos los apellidos
            Console.Write("\n\tIntroduce los apellidos: ");
            e.Apellidos = Console.ReadLine();

            // Pedimos el dni
            Console.Write("\n\tIntroduce el DNI: ");
            e.Dni = Console.ReadLine();

            // Pedimos la fecha de nacimiento
            Console.Write("\n\tIntroduce la fecha de nacimiento: ");
            e.FechaNac = Console.ReadLine();

            // Pedimos la titulacion mas alta
            Console.Write("\n\tIntroduce la titulación más alta: ");
            e.TitulacionMasAlta = Console.ReadLine();

            // Pedimos el número de Seguridad social
            Console.Write("\n\tIntroduce el número de Seguridad Social: ");
            e.NumSegSocial = Convert.ToInt32(Console.ReadLine());

            // Pedimos el número de cuenta
            Console.Write("\n\tIntroduce el número de cuenta: ");
            e.NumCuenta = Convert.ToInt32(Console.ReadLine());

            // Añadimos el id
            e.Id = DevuelveID(listaBD);

            // Añadimos el objeto a la lista
            listaBD.Add(e);

            // Devolvemos la lista actualizada
            return listaBD;
        }

        /**
         * Método que devuelve el último id de la lista sumándole 1
         */
        private int DevuelveID(List<Empleado> listaBD)
        {
            int id = 0;

            // Recorremos la lista
            foreach (Empleado aux in listaBD)
            {
                // Si el id del objeto es mas grande que el id de la variable entonces lo guardamos
                if (aux.Id > id)
                    id = aux.Id;
            }

            // Devolvemos el id + 1
            return id + 1;
        }

        public List<Empleado> ModificaEmpleado(List<Empleado> listaBD)
        {
            // Pedimos el id del empleado
            Console.Write("\n\tIntroduzca el id del empleado a modificar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            // Buscamos el id en la lista, si lo encontramos lo guardamos en una variable
            Empleado e = new Empleado();
            bool encontrado = false;

            // Recorremos la lista para buscar el empleado
            foreach (Empleado aux in listaBD)
            {
                // Si el id del objeto es mas grande que el id de la variable entonces lo guardamos
                if (aux.Id == id)
                {
                    e = aux;
                    encontrado = true;
                    break;
                }
            }

            // Si lo encontramos
            if (encontrado)
            {
                int opcion;
                do
                {
                    // Limpiamos la pantalla
                    Console.Clear();

                    // Mostramos los datos
                    Console.WriteLine("\n\t{0};{1};{2};{3};{4};{5};{6};{7}", e.Id, e.Nombre, e.Apellidos, e.Dni, e.FechaNac, e.TitulacionMasAlta, e.NumSegSocial, e.NumCuenta);

                    // Mostramos las opciones y preguntamos cual modificar
                    Console.WriteLine("\n\n\t\t\t╔═══════════════════════════════╗");
                    Console.WriteLine("\t\t\t║   1) Nombre                   ║");
                    Console.WriteLine("\t\t\t║   2) Apellidos                ║");
                    Console.WriteLine("\t\t\t║   3) DNI                      ║");
                    Console.WriteLine("\t\t\t║   4) Fecha Nacimiento         ║");
                    Console.WriteLine("\t\t\t║   5) Titulacion mas alta      ║");
                    Console.WriteLine("\t\t\t║   6) Numero Seguridad Social  ║");
                    Console.WriteLine("\t\t\t║   7) Numero cuenta            ║");
                    Console.WriteLine("\t\t\t║                               ║");
                    Console.WriteLine("\t\t\t║   0) Salir                    ║");
                    Console.WriteLine("\t\t\t║                               ║");
                    Console.WriteLine("\t\t\t╚═══════════════════════════════╝");
                    Console.Write("\n\tIntroduce una opción: ");
                    opcion = Console.ReadKey().KeyChar - '0';

                    if(opcion <0 || opcion > 7)
                    {
                        Console.WriteLine("\n\n\t** Error: El valor no está dentro del rango **");
                    } 

                    // Controlamos la opcion
                    switch (opcion) 
                    {
                        case 1:
                            Console.Write("\n\t¿Nuevo nombre?: ");
                            e.Nombre = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("\n\t¿Nuevos apellidos?: ");
                            e.Apellidos = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("\n\t¿Nuevo DNI?: ");
                            e.Dni = Console.ReadLine();
                            break;
                        case 4:
                            Console.Write("\n\t¿Nueva fecha de nacimiento?: ");
                            e.FechaNac = Console.ReadLine();
                            break;
                        case 5:
                            Console.Write("\n\t¿Nueva titulacion mas alta?: ");
                            e.TitulacionMasAlta = Console.ReadLine();
                            break;
                        case 6:
                            Console.Write("\n\t¿Nuevo numero de Seguridad social?: ");
                            e.NumSegSocial = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.Write("\n\t¿Nuevo numero de cuenta?: ");
                            e.NumCuenta = Convert.ToInt32(Console.ReadLine());
                            break;
                    }

                    // Para volver al menu
                    if (opcion != 0)
                    {
                        Console.WriteLine("\n\tPulse una tecla para volver al menu");
                        Console.ReadKey(true);
                    }
                } while (opcion != 0);
            } else
                Console.WriteLine("\n\t** Error: El id introducido no existe **");

            // Devolvemos la lista actualizada
            return listaBD;
        }

        public void ExportarEmpleado(List<Empleado> listaBD)
        {
            // Inicializamos la interfaz ficheros
            InterfazFicheros intF = new ImplFicheros();

            if(listaBD.Count <= 0)
                Console.WriteLine("\n\t** Error: No existe ningun empleado **");
            else
            {
                // Preguntamos si se quiere exportar todos los empleados o no
                bool todos = PreguntaSiNo("¿Quiere exportar todos los empleados al fichero? [s=Si/n=No]");

                if (todos)
                {
                    // Exportamos todos los empleados
                    intF.EscribirFichero(listaBD, "c:\\FicherosProg\\CSharp\\repaso.txt");
                }
                else
                {
                    // Pedimos el id del empleado
                    Console.Write("\n\tIntroduzca el id del empleado a exportar: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    // Buscamos el id en la lista, si lo encontramos lo guardamos en una variable
                    Empleado e = new Empleado();
                    bool encontrado = false;

                    // Recorremos la lista para buscar el empleado
                    foreach (Empleado aux in listaBD)
                    {
                        // Si el id del objeto es mas grande que el id de la variable entonces lo guardamos
                        if (aux.Id == id)
                        {
                            e = aux;
                            encontrado = true;
                            break;
                        }
                    }

                    // Si lo encontramos
                    if (encontrado)
                    {
                        List<Empleado> listAuxiliar = new List<Empleado>();
                        listAuxiliar.Add(e);
                        intF.EscribirFichero(listAuxiliar, "c:\\FicherosProg\\CSharp\\repaso.txt");
                    }
                    else
                        Console.WriteLine("\n\t** Error: El id introducido no existe **");
                }
            }
        }

        /**
         * Método que devuelve true o false según la opcion introducida
         */
        private bool PreguntaSiNo(string txt)
        {
            char opcion;

            do
            {
                Console.Write("\n\t{0}: ",txt);
                opcion = Console.ReadKey().KeyChar;

                if(opcion != 's' && opcion != 'n')
                    Console.WriteLine("\n\t** Error: La opción introducida no es correcta **");
            } while (opcion != 's' && opcion != 'n');

            if (opcion == 's')
                return true;

            return false;
        }
    }
}