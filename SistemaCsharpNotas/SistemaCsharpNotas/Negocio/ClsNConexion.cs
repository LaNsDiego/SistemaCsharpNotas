using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaCsharpNotas.Negocio
{
    class ClsNConexion
    {
        static string conex = "Server=Asus-Laptop\\SQLEXPRESS2017;Database=pruebas;UID=sa;Pwd=yatusabespancho";
        private SqlConnection conexion = new SqlConnection(conex);
        private static ClsNConexion instancia = new ClsNConexion();
        public ClsNConexion()
        {

        } 

        public static SqlConnection getConexion()
        {
            return instancia.conexion;
        }
        public void Conectar()
        {
            this.conexion.Open();
        }


        public void Desconectar()
        {
            this.conexion.Close();
        }

        public DataSet EjecutarProcedimiento( string procedimiento ,  ClsNSQLParametro[] parametros = null )
        {
 
            DataSet ds = new DataSet();
            SqlDataAdapter data = new SqlDataAdapter();
            SqlCommand cmd = ClsNConexion.getConexion().CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procedimiento;
            if (parametros != null)
            {
                for (int i = 0; i < parametros.Length; i++)
                {
                    cmd.Parameters.Add(parametros[i].Nombre, parametros[i].Tipo).Value = parametros[i].Valor;
                }
            }

            data.SelectCommand = cmd;
            this.Conectar();
            data.Fill(ds);
            this.Desconectar();
            return ds;

        }

    }
}
