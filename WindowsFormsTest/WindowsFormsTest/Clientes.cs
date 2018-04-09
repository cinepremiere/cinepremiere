using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    class Clientes
    {
        string claveCliente;
        string nombres;
        string curp;
        string paterno;
        string materno;
        string calle;
        string numExt;
        string numInt;
        string cp;
        string colonia;
        string localidad;
        string telefonoCasa;
        string telefonoMovil;
        DateTime fechaRegistro;
        string mail;
        string contrasena;
        int puntos;
        Boolean status;
        string tipoCliente;

        public Clientes()
        {
            
        }

        public Clientes(string claveCliente, string nombres, string curp, string paterno, string materno, string calle, string numExt, string numInt, string cp, string colonia, string localidad, string telefonoCasa, string telefonoMovil, DateTime fechaRegistro, string mail, string contrasena, int puntos, bool status, string tipoCliente)
        {
            this.claveCliente = claveCliente;
            this.nombres = nombres;
            this.curp = curp;
            this.paterno = paterno;
            this.materno = materno;
            this.calle = calle;
            this.numExt = numExt;
            this.numInt = numInt;
            this.cp = cp;
            this.colonia = colonia;
            this.localidad = localidad;
            this.telefonoCasa = telefonoCasa;
            this.telefonoMovil = telefonoMovil;
            this.fechaRegistro = fechaRegistro;
            this.mail = mail;
            this.contrasena = contrasena;
            this.puntos = puntos;
            this.status = status;
            this.tipoCliente = tipoCliente;
        }

        public string ClaveCliente { get => claveCliente; set => claveCliente = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Curp { get => curp; set => curp = value; }
        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno { get => materno; set => materno = value; }
        public string Calle { get => calle; set => calle = value; }
        public string NumExt { get => numExt; set => numExt = value; }
        public string NumInt { get => numInt; set => numInt = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string TelefonoCasa { get => telefonoCasa; set => telefonoCasa = value; }
        public string TelefonoMovil { get => telefonoMovil; set => telefonoMovil = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public bool Status { get => status; set => status = value; }
        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }
    }
}
