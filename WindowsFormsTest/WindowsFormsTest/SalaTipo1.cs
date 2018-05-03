using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    class SalaTipo1 : Sala
    {
        private const int filas = 5;
        private const int elemPorFila = 11;
        private const int capacidad = 50;
        private List<int> liAsientos = new List<int>();

        public override void ObtenerAcomodamiento(DataTable dataTable, int capacidad)
        {
            int k = 0;
            int l = 0;
            for (int i=1;i<=filas;i++)
            {
                //1 para ocupado
                //2 para disponible
                //3 para seleccionado
                //4 para nombre de la fila
                for(int j=1; j <= elemPorFila; j++)
                {
                    if (j == elemPorFila)
                    {
                        liAsientos.Add(4*i);
                        Console.WriteLine(4*i);
                    }
                    else
                    {
                        
                        if (dataTable.Rows.Count > 0 && 
                            int.Parse(dataTable.Rows[k][l].ToString()) == i && 
                            int.Parse(dataTable.Rows[k][l + 1].ToString()) == j)
                        {
                            liAsientos.Add(1);
                            Console.WriteLine(1);
                            if (k + 1 < dataTable.Rows.Count)
                                k++;
                        }
                        else
                        {
                            liAsientos.Add(2);
                            Console.WriteLine(2);
                        }
                    }
                }
            }
        }

        public override void imprimirAcomodamiento()
        {
            for (int i = 0; i < liAsientos.Count; i++)
            {
                Console.Write("salatipo1: "+liAsientos[i] + " ,");
            }
        }

        public override List<int> getAsientos()
        {
            return liAsientos;
        }
    }
}
