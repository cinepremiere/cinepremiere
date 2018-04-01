using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    class Peliculas
    {
        private string claveNombrePelicula = "";
        private string clasificacion = "";
        private string distribuidor = "";
        private string fechaEstreno = "";
        private string fechaRetiro = "";
        private string duracion = "";
        private bool disponible = false;

        public Peliculas()
        {
        }

        public Peliculas(string claveNombrePelicula, string clasificacion, string distribuidor, string fechaEstreno, string fechaRetiro, string duracion, bool disponible)
        {
            this.claveNombrePelicula = claveNombrePelicula;
            this.clasificacion = clasificacion;
            this.distribuidor = distribuidor;
            this.fechaEstreno = fechaEstreno;
            this.fechaRetiro = fechaRetiro;
            this.duracion = duracion;
            this.disponible = disponible;
        }

        public string ClaveNombrePelicula { get => claveNombrePelicula; set => claveNombrePelicula = value; }
        public string Clasificacion { get => clasificacion; set => clasificacion = value; }
        public string Distribuidor { get => distribuidor; set => distribuidor = value; }
        public string FechaEstreno { get => fechaEstreno; set => fechaEstreno = value; }
        public string FechaRetiro { get => fechaRetiro; set => fechaRetiro = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
    }
}
