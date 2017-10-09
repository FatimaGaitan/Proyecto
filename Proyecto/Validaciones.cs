using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto
{
    class Validaciones
    {
        public static bool validar_Nombre(ref TextBox Texto, ref ErrorProvider Error)
        {
            String expresión = "[a-zA-ZñÑáéíóúÁÉÍÓÚäëïöüÄËÏÖÜ\\s]{2,50}";

            if (Regex.IsMatch(Texto.Text, expresión))
            {
                if (Regex.Replace(Texto.Text, expresión, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    Error.SetError(Texto, "Nombre ingresado no válido.");
                    return false;
                }
            }
            else
            {
                Error.SetError(Texto, "Nombre ingresado no válido.");
                return false;

            }
        }
        public static bool validar_correo(ref TextBox correo, ref ErrorProvider Error)
        {
            Error.Clear();
            String expresion;
            expresion = "^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,3})$";
            while (correo.Text.Contains(" "))
            {
                correo.Text = correo.Text.Replace(" ", "");
                correo.SelectionStart = correo.Text.Length;
            }
            if (Regex.IsMatch(correo.Text, expresion))
            {
                if (Regex.Replace(correo.Text, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    Error.SetError(correo, "El correo ingresado en inválido.");
                    return false;
                }
            }
            else
            {
                Error.SetError(correo, "El correo ingresado en inválido.");
                return false;
            }
        }
        public static bool validar_contraseñas(ref TextBox Contraseña, ref ErrorProvider Error)
        {
            String expresión = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
            if(Regex.IsMatch(Contraseña.Text,expresión))
            {
                if(Regex.Replace(Contraseña.Text,expresión,String.Empty).Length==0)
                {
                    return true;
                }
                else
                {
                    Error.SetError(Contraseña, "La contraseña debe tener al menos 8 caracteres, una letra mayuscula, un número y un caracter");
                    return false;
                }
            }
            else
            {
                Error.SetError(Contraseña, "La contraseña debe tener al menos 8 caracteres, una letra mayuscula, un número y un caracter");
                return false;
            }
        }
        public static bool Contraseñas_Iguales(ref TextBox Contraseña1, ref TextBox Contraseña2, ref ErrorProvider Error)
        {
            Error.Clear();
            if (Contraseña1.Text != Contraseña2.Text)
            {
                Error.SetError(Contraseña2, "Las contraseñas no son iguales.");
                return false;
            }
            else
                return true;
        }
        public static bool validar_Año(ref TextBox Texto, ref ErrorProvider Error)
        {
            int Año = 0;
            if(int.TryParse(Texto.Text,out Año))
            {
                if(Año>DateTime.Now.Year)
                    Error.SetError(Texto, "El año elegido, sobrepasa al año actual");
                else
                    return true;
            }
            else
                Error.SetError(Texto, "Debe ingresar solamente números enteros");
            return false;
        }
        public static bool IsNotNullOrEmty(ref TextBox Cadena, ref ErrorProvider Error)
        {
            if (String.IsNullOrEmpty(Cadena.Text))
            {
                Error.SetError(Cadena, "Campo obligatorio.");
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool validar_Duración(ref MaskedTextBox Cadena,ref ErrorProvider Error)
        {
            if (Cadena.Text.Length == 5)
            {
                int num = Convert.ToInt32(Cadena.Text.Substring(3, 1));
                if (num > 5)
                {
                    string Cadena2 = Cadena.Text;
                    Cadena.Text = Cadena2.Substring(0, 3) + 5 + Cadena2.Substring(4, 1);
                }
                return true;
            }
            else
            {
                Error.SetError(Cadena, "No ha colocado una duración válida");
                return false;
            }
        }
        public static bool ValidarNomApe(ref TextBox Texto, ref ErrorProvider Error)
        {
            Texto.Text = RetornarMayúscula(ref Texto);
            Texto.SelectionStart = Texto.Text.Length;
            validar_Nombre(ref Texto, ref Error);
            return !string.IsNullOrEmpty(Texto.Text);
        }
        private static string RetornarMayúscula(ref TextBox Cadena)
        {
            while (Cadena.Text.Contains("  "))
            {
                Cadena.Text = Cadena.Text.Replace("  ", " ");
            }
            if (Cadena.Text == " ")
            {
                Cadena.Text = Cadena.Text.Trim();
            }
            if ((Cadena.Text.Length >= 1))
            {
                if (!(string.IsNullOrEmpty(Cadena.Text)))
                {
                    try
                    {
                        string[] modificado = Cadena.Text.Split(' ');
                        string retornar = modificado[0].Substring(0, 1).ToUpper() + modificado[0].Substring(1, modificado[0].Length - 1);
                        for (int i = 1; i < modificado.Length; i++)
                        {
                            retornar = retornar + ' ' + modificado[i].Substring(0, 1).ToUpper() + modificado[i].Substring(1, modificado[i].Length - 1);
                        }
                        return retornar;
                    }
                    catch
                    {
                        return Cadena.Text;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
                return null;
        }
    }
}
