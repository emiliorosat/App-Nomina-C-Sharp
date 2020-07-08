using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina.Strategy
{
    class SCuarentenaFase2 : ISueldo
    {
        public string CalculoDeSueldo(int horas, double precio)
        {
            double sueldo = (horas * precio) * 15;
            double afp = 0;
            double ars = sueldo * 0.0304;
            sueldo -= ars;
            return "Sueldo a pagar: " + sueldo + "\nDescuentos:\nAFP: " + afp + "\nARS: " + ars;
        }
    }
}
