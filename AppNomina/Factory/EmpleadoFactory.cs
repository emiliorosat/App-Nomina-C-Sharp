using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina.Factory
{
    class EmpleadoFactory
    {
        public IEmpleado NuevoEmpleado(int tipo)
        {
            if(tipo == 1)
            {
                return new ETiempoCompleto();
            }else if(tipo == 2)
            {
                return new EMedioTiempo();
            }else if(tipo == 3)
            {
                return new ETemporero();
            }
            else
            {
                return null;
            }
        }
    }
}
