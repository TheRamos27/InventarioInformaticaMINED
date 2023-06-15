using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.MINED;
using System.Data;

namespace CapaNegocio.MINED
{
    public class CN_NumeroIp
    {
        private CD_NumeroIp herramientaCD = new CD_NumeroIp();

        public DataTable MostrarNumeroIp()
        {

            DataTable tabla = new DataTable();
            tabla = herramientaCD.Mostrar();
            return tabla;
        }
        public void InsetarNumeroIp(string nombreAsignacion, string nIp, string nombreEquipo)
        {

            herramientaCD.Insertar(nombreAsignacion, nIp, nombreEquipo);
        }

        public void EditarNumeroIp(string nombreAsignacion, string nIp, string nombreEquipo, string id)
        {
            herramientaCD.Editar(nombreAsignacion, nIp, nombreEquipo, Convert.ToInt32(id));
        }

        public void EliminarNumeroIp(string id)
        {

            herramientaCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
