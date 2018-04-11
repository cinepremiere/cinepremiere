using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    class Funciones
    {
        int claveFuncion;
        int claveSala;
        string clavePelicula;
        int claveTipoFuncion;
        int claveIdioma;
        int claveSubtitulos;
        DateTime fecha;
        DateTime hora;
        bool disponible;
        string imgPath;

        public Funciones()
        {

        }

        public Funciones(int claveFuncion, int claveSala, string clavePelicula, int claveTipoFuncion, int claveIdioma, int claveSubtitulos, DateTime fecha, DateTime hora, bool disponible, string imgPath)
        {
            this.claveFuncion = claveFuncion;
            this.claveSala = claveSala;
            this.clavePelicula = clavePelicula;
            this.claveTipoFuncion = claveTipoFuncion;
            this.claveIdioma = claveIdioma;
            this.claveSubtitulos = claveSubtitulos;
            this.fecha = fecha;
            this.hora = hora;
            this.disponible = disponible;
            this.imgPath = imgPath;
        }

        public int ClaveFuncion { get => claveFuncion; set => claveFuncion = value; }
        public int ClaveSala { get => claveSala; set => claveSala = value; }
        public string ClavePelicula { get => clavePelicula; set => clavePelicula = value; }
        public int ClaveTipoFuncion { get => claveTipoFuncion; set => claveTipoFuncion = value; }
        public int ClaveIdioma { get => claveIdioma; set => claveIdioma = value; }
        public int ClaveSubtitulos { get => claveSubtitulos; set => claveSubtitulos = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
        public string ImgPath { get => imgPath; set => imgPath = value; }
    }
}
