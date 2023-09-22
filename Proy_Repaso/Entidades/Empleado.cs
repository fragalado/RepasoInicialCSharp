using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Repaso
{
    class Empleado
    {
        // Atributos

        int id;
        string nombre, apellidos, dni;
        string fechaNac;
        string titulacionMasAlta;
        int numSegSocial;
        int numCuenta;

        // Constructores -> Constructor vacío

        // Propiedades básicas

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public string TitulacionMasAlta { get => titulacionMasAlta; set => titulacionMasAlta = value; }
        public int NumSegSocial { get => numSegSocial; set => numSegSocial = value; }
        public int NumCuenta { get => numCuenta; set => numCuenta = value; }
    }
}
