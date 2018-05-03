using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTest
{
    public abstract class Sala
    {
        public abstract void ObtenerAcomodamiento(DataTable dataTable, int capacidad);
        public abstract List<int> getAsientos();
        public abstract void imprimirAcomodamiento();
    }
}
