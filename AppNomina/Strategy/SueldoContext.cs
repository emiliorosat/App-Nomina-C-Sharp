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

        public void CalculoDeSueldo(int horas, double precio)
        {
            this.estrategia.CalculoDeSueldo(horas, precio);
        }
    }
}
