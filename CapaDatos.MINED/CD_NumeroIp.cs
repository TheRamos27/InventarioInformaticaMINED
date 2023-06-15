using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.MINED
{
    public class CD_NumeroIp
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarNumeroIp";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(string nombreAsignacion, string nIp, string nombreEquipo)
        {
            //PROCEDIMNIENTO

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarNumeroIp";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreAsignacion", nombreAsignacion);
            comando.Parameters.AddWithValue("@NIp", nIp);
            comando.Parameters.AddWithValue("@NombreEquipo", nombreEquipo);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(string nombreAsignacion, string nIp, string nombreEquipo, int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarNumeroIp";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreAsignacion", nombreAsignacion);
            comando.Parameters.AddWithValue("@NIp", nIp);
            comando.Parameters.AddWithValue("@NombreEquipo", nombreEquipo);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarNumeroIp";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idIp", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
