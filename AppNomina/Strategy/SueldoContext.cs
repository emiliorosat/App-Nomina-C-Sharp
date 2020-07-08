using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina.Strategy
{
    class SueldoContext
    {
        private ISueldo estrategia;

        public SueldoContext(ISueldo sueldo)
        {
            estrategia = sueldo;
        }

        public string CalculoDeSueldo(int horas, double precio)
        {
            return this.estrategia.CalculoDeSueldo(horas, precio);
        }
    }
}
