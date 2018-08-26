using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCsharpNotas.Entidad
{
    class ClsEstudiante
    {
        public int Id;
        public string Codigo;
        public string Dni;
        public string Nombres;
        public string Apellidos;
        public string Sexo;
        public string Correo;


        public ClsEstudiante(int id, string codigo, string dni, string nombres, string apellidos, string sexo, string correo)
        {
            Id = id;
            Codigo = codigo;
            Dni = dni;
            Nombres = nombres;
            Apellidos = apellidos;
            Sexo = sexo;
            Correo = correo;
        }
    }
}
