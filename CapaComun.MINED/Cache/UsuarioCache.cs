using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.MINED.Cache
{
    public static class UsuarioCache
    {
        public static int Id { get; set; }
        public static string Usuario {  get; set; }
        public static string Contraseña { get; set; }
        public static string Nombres { get; set; }
        public static string Apellidos { get; set; }
        public static string Posicion { get; set; }
        public static string Correo { get; set; }
    }
}
