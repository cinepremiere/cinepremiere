using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    class Validador
    {
        public bool validarNombreCompleto(string cadena)
        {
            bool esValido = true;

            Console.Write("analizando" + cadena + " ");
            var name = cadena.Trim();
            if (Regex.IsMatch(name, @"^[0-9\\\/\.¿?¡!*%$#""@{};,:\[\]<>_()]$"))
            {
                Console.WriteLine("fail");
                esValido = false;
            }
            //name = name.Replace("'", "&#39;");
            //Console.WriteLine(name);

            return esValido;
        }

        public bool validarCurp(string cadena)
        {
            bool esValido = true;

            Console.Write(cadena + " ");
            var name = cadena.Trim();
            if (!Regex.IsMatch(name, @"^[0-9A-Z\b]$"))
            {
                Console.WriteLine("fail");
                esValido = false;
            }
            //name = name.Replace("'", "&#39;");
            Console.WriteLine(name);

            return esValido;
        }

        public bool validarsoloNumeros(string cadena)
        {
            bool esValido = true;

            Console.Write(cadena + " ");
            var name = cadena.Trim();
            if (!Regex.IsMatch(name, @"^[0-9\b]$"))
            {
                Console.WriteLine("fail");
                esValido = false;
            }
            //name = name.Replace("'", "&#39;");
            Console.WriteLine(name);

            return esValido;
        }

        public bool validarFormatoCURP(string cadena)
        {
            bool esValido = true;

            Console.Write(cadena + " ");
            var name = cadena.Trim();
            if (!Regex.IsMatch(name, @"^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0\d|1[0-2])(?:[0-2]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$"))
            {
                Console.WriteLine("fail");
                esValido = false;
            }
            //name = name.Replace("'", "&#39;");
            Console.WriteLine(name);

            return esValido;
        }

        public bool validarFormatoCorreo(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }

//      (? i) puts us in case-insensitive mode
//      ^ ensures we're at the beginning of the string
//      [a-z]+ matches one or more letters
//      [-]?[a - z]+ matches an optional single space or dash followed by letters...
//      (?:[ -]?[a - z]+)* and this is allowed zero or more times
//      $ asserts that we have reached the end of the string
}
