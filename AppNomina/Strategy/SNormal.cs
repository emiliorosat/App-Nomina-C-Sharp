using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina.Strategy
{
    class SNormal : ISueldo
    {


        public string CalculoDeSueldo(int horas, double precio)
        {
            double sueldo = (horas * precio) * 30;
            double afp = sueldo * 0.0287;
            double ars = sueldo * 0.0304;
            sueldo -= afp + ars;
            return "Sueldo a pagar: " + sueldo + "\nDescuentos:\nAFP: " + afp + "\nARS: " + ars;
        }
    }
}
