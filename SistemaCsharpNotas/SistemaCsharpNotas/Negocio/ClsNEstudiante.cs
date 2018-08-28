using SistemaCsharpNotas.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCsharpNotas.Negocio
{
    class ClsNEstudiante
    {

        public DataSet Agregar(ClsEstudiante estudiante)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[6];//el numero variara de acuerdo a los campos de la tabla en la base de datos
            //ClsNSQLParametro es un clase que se creo que recive en el constructor 3 parametros
            //new ClsNSQLParametro(valor,@columna,tipo)
            parametros[0] = new ClsNSQLParametro(estudiante.Codigo, "@codigo", SqlDbType.Char);
            parametros[1] = new ClsNSQLParametro(estudiante.Dni, "@dni", SqlDbType.Char);
            parametros[2] = new ClsNSQLParametro(estudiante.Nombres, "@nombres", SqlDbType.VarChar);
            parametros[3] = new ClsNSQLParametro(estudiante.Apellidos, "@apellidos", SqlDbType.VarChar);
            parametros[4] = new ClsNSQLParametro(estudiante.Sexo, "@sexo", SqlDbType.Char);
            parametros[5] = new ClsNSQLParametro(estudiante.Correo, "@correo", SqlDbType.VarChar);

            //La funcion EjecutarProcedimiento ejecuta un procedimiento almacenada 
            //con los parametros correspondientes y devuelve un DataSet
            return ClsNConexion.EjecutarProcedimiento("spCrearEstudiante", parametros);
        }

        public DataSet Listar()
        {
            return ClsNConexion.EjecutarProcedimiento("spListarEstudiante");
        }

        public DataSet Modificar(ClsEstudiante estudiante)
        {
            ClsNSQLParametro[] parametros = new ClsNSQLParametro[6];//el numero variara de acuerdo a los campos de la tabla en la base de datos
            //ClsNSQLParametro es un clase que se creo que recive en el constructor 3 parametros
            //new ClsNSQLParametro(valor,@columna,tipo)
            parametros[0] = new ClsNSQLParametro(estudiante, "@id", SqlDbType.Char);
            parametros[1] = new ClsNSQLParametro(estudiante.Codigo, "@codigo", SqlDbType.Char);
            parametros[2] = new ClsNSQLParametro(estudiante.Dni, "@dni", SqlDbType.Char);
            parametros[3] = new ClsNSQLParametro(estudiante.Nombres, "@nombres", SqlDbType.VarChar);
            parametros[4] = new ClsNSQLParametro(estudiante.Apellidos, "@apellidos", SqlDbType.VarChar);
            parametros[5] = new ClsNSQLParametro(estudiante.Sexo, "@sexo", SqlDbType.Char);
            parametros[6] = new ClsNSQLParametro(estudiante.Correo, "@correo", SqlDbType.VarChar);

            //La funcion EjecutarProcedimiento ejecuta un procedimiento almacenada 
            //con los parametros correspondientes y devuelve un DataSet
            return ClsNConexion.EjecutarProcedimiento("spModificarEstudiante", parametros);
        }
    }
}
