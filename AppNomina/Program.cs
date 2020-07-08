using AppNomina.Facade;
using AppNomina.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeMain App = new FacadeMain();
            int opcion = App.Home();
            if(opcion == 1)
            {
                App.CrearEmpleado();
            }else if(opcion == 2)
            {
                App.PagarSueldo();
            }
            else
            {
                App.Salir();
            }

            Console.ReadKey();
        }
    }
}
