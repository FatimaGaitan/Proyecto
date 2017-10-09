using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Proyecto
{
    class Cifrado
    {
        public static String encriptar(string cadena)
        {
            string hashed = BCrypt.Net.BCrypt.HashPassword(cadena, BCrypt.Net.BCrypt.GenerateSalt());
            return (hashed);
        }
        public static bool desencriptar(String cadena, String password)
        {
            try
            {
                bool verify = BCrypt.Net.BCrypt.Verify(cadena, password);
                return verify;
            }
            catch
            {
                return false;
            }
        }
    }
}