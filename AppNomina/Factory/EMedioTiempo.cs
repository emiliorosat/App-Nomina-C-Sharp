using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNomina.Factory
{
    public class EMedioTiempo : IEmpleado
    {
        private string nombre;
        private double precioPorHora;
        private string medioDePago = "Cuenta Bancaria";
        private string cuentaBancaria;
        private int horasDiarias = 4;
        private string tipoEmpleado = "Medio Tiempo";



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
