using AppNomina.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina.Facade
{
    class FacadeMain
    {
        List<IEmpleado> empleados = new List<IEmpleado>();
        FacadeEmpleado App = new FacadeEmpleado();
        public int Home()
        {
            Console.Clear();
            Console.WriteLine("################### Nomina ###################");
            Console.WriteLine("\nSeleccione una Opcion");
            Console.WriteLine("[1]Crear Empleado  [2]Pagar Sueldo  [3]Salir\n");
            Console.Write("Opcion: ");
            try
            {
                int opt = int.Parse(Console.ReadLine());
                if(opt < 1 || opt > 3)
                {
                    Console.Clear();
                    this.Home();
                }
                else
                {
                    return opt;
                }

            }
            catch(Exception err)
            {
                Console.Clear();
                this.Home();
            }
            return 0;
        }

        public void CrearEmpleado()
        {
            Console.Clear();
            Console.WriteLine("############ Nomina:Nuevo Empleado ############");
            Console.WriteLine("\nSeleccione una Opcion");
            Console.WriteLine("[1]Empleado Tempo Completo  [2]Empleado Medio Tiempo");
            Console.WriteLine("[3]Empleado Temporero       [4]Volver\n");
            Console.Write("Opcion: ");
            try
            {
                int opt = int.Parse(Console.ReadLine());
                if (opt >= 1 || opt <= 3)
                {
                    Console.Clear();
                    Console.WriteLine("############ Nomina:Nuevo Empleado ############");
                    empleados.Add( App.CrearEmpleado(opt) );
                }
                else
                {
                    Console.Clear();
                    this.CrearEmpleado();
                }

            }
            catch (Exception err)
            {
                Console.Clear();
                this.CrearEmpleado();
            }
        }

        public void PagarSueldo()
        {
            Console.Clear();
            Console.WriteLine("######## Nomina:Situacion Nacional ########");
            Console.WriteLine("\nSeleccione una Opcion");
            Console.WriteLine("[1]Normal             [2]Cuarentena Fase 2");
            Console.WriteLine("[3]Cuarentena Total   [4]Volver\n");
            Console.Write("Opcion: ");
            try
            {
                int opt = int.Parse(Console.ReadLine());
                if (opt >= 1 || opt <= 3)
                {
                    Console.Clear();
                    Console.WriteLine("######## Nomina:Pago Nomina ########");
                    foreach (var empleado in empleados)
                    {
                        Console.WriteLine("Empleado: "+empleado.GetNombre());
                        Console.WriteLine(App.PagarSueldo(opt, empleado));
                        Console.WriteLine("\n");
                    }
                        Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    this.PagarSueldo();
                }

            }
            catch (Exception err)
            {
                Console.Clear();
                this.PagarSueldo();
            }
        }

        public void Salir()
        {
            Console.Clear();
            Console.WriteLine("Cerrando Sistema...");
            Console.ReadKey();
        }
    }
}
