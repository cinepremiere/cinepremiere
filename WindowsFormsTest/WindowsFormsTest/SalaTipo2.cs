using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    class SalaTipo2 : Sala
    {
        private const int filas = 4;
        private const int elemPorFila = 11;
        private const int capacidad = 20;
        List<int> liAsientos = new List<int>();

        public override List<int> getAsientos()
        {
            return liAsientos;
        }

        public override void ObtenerAcomodamiento(DataTable dataTable, int capacidad)
        {
            if (SalaTipo2.capacidad == capacidad)
            {
                int k = 0;
                int l = 0;
                int m = 0;
                for (int i = 1; i <= filas; i++)
                {
                    //1 para ocupado
                    //2 para disponible
                    //3 para seleccionado
                    //4 para nombre de la fila
                    //5 para vacío
                    for (int j = 1; j <= elemPorFila; j++)
                    {
                        if ((((j >= 1 && j < 5) || (j >= 7 && j < 11)) && (i >= 1 && i < 3))
                            || (((j == 1) || (j == 10)) && (i >= 3 && i < 5)))
                        {
                            liAsientos.Add(5);
                        }
                        else if (j == elemPorFila)
                        {
                            liAsientos.Add(4 * i);
                            m =0;
                        }
                        else
                        {
                            m++;
                            if (dataTable.Rows.Count>0 && 
                                (int)dataTable.Rows[k][l] == i && 
                                (int)dataTable.Rows[k][l + 1] == m)
                            {
                                liAsientos.Add(1);
                                if (k + 1 < dataTable.Rows.Count)
                                    k++;
                            }
                            else
                            {
                                liAsientos.Add(2);
                            }
                        }
                    }
                }
            }
        }
        public override void imprimirAcomodamiento()
        {
            for (int i = 0; i < liAsientos.Count; i++)
            {
                Console.WriteLine("salatipo2 :"+liAsientos[i] + " ,");
            }
        }
    }
}
