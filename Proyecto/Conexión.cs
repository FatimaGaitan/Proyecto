﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Conexión
    {
        public string Usuario = "system";
        public string contraseña = "Stilinski04";
        public string cadena;

        public Conexión()
        {
            cadena = "Data Source = " + Globales.gbServidor + ";USER ID=" + Globales.gbORacle_Usuario + ";Password=" + Globales.gbClave_ORacle_Usuario;
        }
    }
}
