using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina.Strategy
{
    public interface ISueldo
    {
        string CalculoDeSueldo(int horas, double precio);
    }
}
