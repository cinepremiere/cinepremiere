using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    class Usuario
    {
        int claveUsuario;
        string curp;
        string nombres;
        string paterno;
        string materno;
        int claveTipoUsuario;
        string calle;
        string numInt;
        string numExt;
        string cp;
        string colonia;
        string localidad;
        string telCasa;
        string telMovil;
        string inicioContrato;
        string inicioTurno;
        string finTurno;
        string mail;
        float sueldo;
        string password;
        int disponible;

        public Usuario()
        {

        }

        public Usuario(int claveUsuario, string curp, string nombres, string paterno, string materno, int claveTipoUsuario, string calle, string numInt, string numExt, string cp, string colonia, string localidad, string telCasa, string telMovil, string inicioContrato, string inicioTurno, string finTurno, string mail, float sueldo, string password, int disponible)
        {
            this.claveUsuario = claveUsuario;
            this.curp = curp;
            this.nombres = nombres;
            this.paterno = paterno;
            this.materno = materno;
            this.claveTipoUsuario = claveTipoUsuario;
            this.calle = calle;
            this.numInt = numInt;
            this.numExt = numExt;
            this.cp = cp;
            this.colonia = colonia;
            this.localidad = localidad;
            this.telCasa = telCasa;
            this.telMovil = telMovil;
            this.inicioContrato = inicioContrato;
            this.inicioTurno = inicioTurno;
            this.finTurno = finTurno;
            this.mail = mail;
            this.sueldo = sueldo;
            this.password = password;
            this.disponible = disponible;
        }

        public int ClaveUsuario { get => claveUsuario; set => claveUsuario = value; }
        public string Curp { get => curp; set => curp = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno { get => materno; set => materno = value; }
        public int ClaveTipoUsuario { get => claveTipoUsuario; set => claveTipoUsuario = value; }
        public string Calle { get => calle; set => calle = value; }
        public string NumInt { get => numInt; set => numInt = value; }
        public string NumExt { get => numExt; set => numExt = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string TelCasa { get => telCasa; set => telCasa = value; }
        public string TelMovil { get => telMovil; set => telMovil = value; }
        public string InicioContrato { get => inicioContrato; set => inicioContrato = value; }
        public string InicioTurno { get => inicioTurno; set => inicioTurno = value; }
        public string FinTurno { get => finTurno; set => finTurno = value; }
        public string Mail { get => mail; set => mail = value; }
        public float Sueldo { get => sueldo; set => sueldo = value; }
        public string Password { get => password; set => password = value; }
        public int Disponible { get => disponible; set => disponible = value; }
    }
}
