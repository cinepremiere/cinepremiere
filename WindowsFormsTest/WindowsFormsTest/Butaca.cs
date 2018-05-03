using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    public class Butaca
    {
        private int fila;
        private int asiento;
        private string filaLetra;

        public Butaca()
        {

        }

        public Butaca(int fila, int asiento, string filaLetra)
        {
            this.filaLetra = filaLetra;
            this.fila = fila;
            this.asiento = asiento;
        }

        public int Fila { get => fila; set => fila = value; }
        public int Asiento { get => asiento; set => asiento = value; }
        public string FilaLetra { get => filaLetra; set => filaLetra = value; }
    }
}
