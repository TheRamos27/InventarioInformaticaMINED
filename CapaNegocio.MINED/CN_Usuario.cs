using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.MINED;

namespace CapaNegocio.MINED
{
    public class CN_Usuario
    {
        private CD_Usuario herramientaUsuarioCD = new CD_Usuario();

        public DataTable MostrarUsuario()
        {

            DataTable tabla = new DataTable();
            tabla = herramientaUsuarioCD.Mostrar();
            return tabla;
        }

        public void InsertarUsuario(string usuario, string contraseña, string nombres, string apellidos, string posicionn, string correo)
        {

            herramientaUsuarioCD.Insertar(usuario, contraseña, nombres, apellidos, posicionn, correo);
        }

        public void EditarUsuario(string usuario, string contraseña, string nombres, string apellidos, string posicionn, string correo, string id)
        {
            herramientaUsuarioCD.Editar(usuario, contraseña, nombres, apellidos, posicionn, contraseña, Convert.ToInt32(id));
        }

        public void EliminarUsuario(string id)
        {

            herramientaUsuarioCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
