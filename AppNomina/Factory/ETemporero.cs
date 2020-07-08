using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina.Factory
{
    public class ETemporero : IEmpleado
    {
        private string nombre;
        private double precioPorHora;
        private string medioDePago = "Cheque";
        private int horasDiarias = 9;
        private string tipoEmpleado = "Temporal";


        public string GetCuentaBancaria()
        {
            return null;
        }

        public int GetHorasDiarias()
        {
            return this.horasDiarias;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public double GetPrecioHora()
        {
            return this.precioPorHora;
        }

        public void SetHorasDiariasATrabajar(int horas)
        {
            this.horasDiarias = horas;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetNumeroDeCuentaBancaria(string cuenta)
        {
            
        }

        public void SetPrecioHora(double precio)
        {
            this.precioPorHora = precio;
        }
    }
}
