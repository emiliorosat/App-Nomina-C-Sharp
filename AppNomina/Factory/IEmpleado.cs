using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina.Factory
{
    public interface IEmpleado
    {
        void SetHorasDiariasATrabajar(int horas);
        void SetPrecioHora(double precio);
    }
}
