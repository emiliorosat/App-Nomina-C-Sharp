using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina.Factory
{
    public class ETiempoCompleto : IEmpleado
    {
        public string nombre;
        public double precioPorHora;
        public string medioDePago = "Cuenta Bancaria";
        public string cuentaBancaria;
        public int horasDiarias = 8;
        public string tipoEmpleado = "Tiempo Completo";

        public string GetCuentaBancaria()
        {
            return this.cuentaBancaria;
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
            this.cuentaBancaria = cuenta;
        }

        public void SetPrecioHora(double precio)
        {
            this.precioPorHora = precio;
        }
    }
}
