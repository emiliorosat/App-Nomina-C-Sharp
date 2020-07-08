using AppNomina.Factory;
using AppNomina.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina.Facade
{
     class FacadeEmpleado
    {

        private EmpleadoFactory empleadoFactory = new EmpleadoFactory();

        public IEmpleado CrearEmpleado(int tipo)
        {
            IEmpleado nuevoEmpleado = empleadoFactory.NuevoEmpleado(tipo);

            if (!typeof(ETemporero).IsInstanceOfType(nuevoEmpleado))
            {
                
            }

            return nuevoEmpleado;
        }

        public void PagarSueldo(int estado)
        {
            SueldoContext pago;

            if (estado == 1)
            {
                pago = new SueldoContext(new SNormal());
                
            }else if(estado == 2)
            {
                pago = new SueldoContext(new SCuarentenaFase2());
            }
            else
            {
                pago = new SueldoContext(new SCuarentenaTotal());
            }

            string result = pago.CalculoDeSueldo();

        }




        
    }
}
