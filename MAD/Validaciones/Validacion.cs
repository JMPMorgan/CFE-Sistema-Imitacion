using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MAD.Validaciones
{
    class Validacion
    {
        public bool SoloLetras(string Nombre)
        {
            int lenght = Nombre.Length;
            char[] nombre = Nombre.ToCharArray(0, lenght);
            Regex Val = new Regex(@"^[a-zA-Z' ']+$");
            if (Val.IsMatch(Nombre) == true)
            {
                if (string.IsNullOrWhiteSpace(Nombre)==false)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public bool SoloLetrasOficial(string Nombre)
        {
            int lenght = Nombre.Length;
            char[] nombre = Nombre.ToCharArray(0, lenght);
            Regex Val = new Regex(@"^[a-zA-Z]+$");
            if (Val.IsMatch(Nombre) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool soloNumeros(string Numeros)
        {
            Regex Val = new Regex(@"^[0-9]+$");
            if (Val.IsMatch(Numeros)==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
         public bool soloNumerosPunto(string numero)
        {
            Regex Val = new Regex(@"^[0-9'.']+$");
            if (Val.IsMatch(numero) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool NoEspacios(string Nombre)
        {
            if (Nombre.Contains(" ")==true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool email(string EMAIL)
        {
            int lenght = EMAIL.Length;
            char[] correo = EMAIL.ToCharArray(0, lenght);
            int checkarroba = 0;
            int checkpunto = 0;
            lenght = correo.Length;

            int i = 0;
            while (correo.Length!=i)
            {
                if (correo[i] == '@')
                {
                    checkarroba++;
                }
                if (correo[i] == '.' && checkarroba == 1)
                {
                    checkpunto++;
                }
                i++;
            }
            if(checkpunto==1 && checkarroba == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string returnMesNumero(string mes)
        {
            if (mes=="Enero")
            {
                mes = "1";
            }
            else if (mes == "Febrero")
            {
                mes = "2";
            }
            else if (mes == "Marzo")
            {
                mes = "3";
            }
            else if (mes == "Abril")
            {
                mes = "4";
            }
            else if (mes == "Mayo")
            {
                mes = "5";
            }
            else if (mes == "Junio")
            {
                mes = "6";
            }
            else if (mes == "Julio")
            {
                mes = "7";
            }
            else if (mes == "Agosto")
            {
                mes = "8";
            }
            else if (mes == "Septiembre")
            {
                mes = "9";
            }
            else if (mes == "Octubre")
            {
                mes = "10";
            }
            else if (mes == "Noviembre")
            {
                mes = "11";
            }
            else if (mes == "Diciembre")
            {
                mes = "12";
            }
            return mes;
        }
    }
}
