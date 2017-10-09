using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Globales
    {
        public static String gbORacle_Usuario = "system";
        public static String gbClave_ORacle_Usuario = "Stilinski04";
        public static String gbTipo_Usuario = "Administrador";
        public static String gbCodUsuario;
        public static String gbNombre_Usuario;
        public static String gbClaveUsuario;
        public static String gbIP="192.168.0.15";
        public static String gbServidor = gbIP + ":1521/orcl";
        public static String Cod_Usuario_seleccionado = "";
        public static String gbError;
        public static String gbCodigoCancion;
        public Globales()
        {
        }
        public static void Inicializar(String pCodUsuario, String pNombreUsuario, String pTipoUsuario, String pClaveUsuario)
        {
            gbCodUsuario = pCodUsuario;
            gbClaveUsuario = pClaveUsuario;
            gbTipo_Usuario = pTipoUsuario;
            gbNombre_Usuario = pNombreUsuario;
        }
        public static void InicioServidor(String ip)
        {
            gbIP = ip;
            gbServidor = gbIP + ":1521/orcl";
        }
    }

}
