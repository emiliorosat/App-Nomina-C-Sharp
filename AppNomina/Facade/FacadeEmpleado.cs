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

            Console.Write("Nombre: ");
            nuevoEmpleado.SetNombre(Console.ReadLine());
            Console.Write("Precio Por Hora a Pagar: ");
            nuevoEmpleado.SetPrecioHora(double.Parse(Console.ReadLine()));

            if (!typeof(ETemporero).IsInstanceOfType(nuevoEmpleado))
            {
                Console.Write("Numero de Cuenta: ");
                nuevoEmpleado.SetNumeroDeCuentaBancaria(Console.ReadLine());
            }

            return nuevoEmpleado;
        }

        public string PagarSueldo(int estado, IEmpleado empleado)
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

            return pago.CalculoDeSueldo(empleado.GetHorasDiarias(), empleado.GetPrecioHora());

        }




        
    }
}
