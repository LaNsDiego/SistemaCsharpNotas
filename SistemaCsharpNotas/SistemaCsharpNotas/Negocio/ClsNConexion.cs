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
        SqlConnection conexion = new SqlConnection(conex);

        public void Abrir()
        {
            this.conexion.Open();
        }


        public void Cerrar()
        {
            this.conexion.Close();
        }

        public DataSet EjecutarProcedimiento( string procedimiento ,  ClsNSQLParametro[] parametros )
        {
 
            DataSet ds = new DataSet();
            SqlDataAdapter data = new SqlDataAdapter();
            SqlCommand cmd = this.conexion.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procedimiento;
            for (int i = 0; i < parametros.Length ; i++)
            {
                cmd.Parameters.Add(parametros[i].Nombre, parametros[i].Tipo).Value = parametros[i].Valor;
            }

            //cmd.ExecuteNonQuery()
            data.SelectCommand = cmd;
            this.Abrir();
            data.Fill(ds);
            this.Cerrar();
            return ds;

        }
    }
}
