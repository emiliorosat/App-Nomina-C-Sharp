using AppNomina.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina.Strategy
{
    class SCuarentenaTotal : ISueldo
    {

        public string CalculoDeSueldo(int horas, double precio)
        {
            double sueldo = (horas * precio) * 7;
            double afp = 0;
            double ars = 0;
            return "Sueldo a pagar: " + sueldo + "\nDescuentos:\nAFP: " + afp + "\nARS: " + ars;
        }
    }
}
