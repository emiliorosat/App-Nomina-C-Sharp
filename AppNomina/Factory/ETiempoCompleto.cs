﻿using System;
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
        public string medioDePago;
        public string cuentaBancaria;
        public int horasDiarias = 8;
        public string tipoEmpleado = "Tiempo Completo";

        public string Nombre { get => nombre; set => nombre = value; }
        public double PrecioPorHora { get => precioPorHora; set => precioPorHora = value; }
        public string MedioDePago { get => medioDePago; set => medioDePago = value; }
        public string CuentaBancaria { get => cuentaBancaria; set => cuentaBancaria = value; }
        public int HorasDiarias { get => horasDiarias; set => horasDiarias = value; }
        public string TipoEmpleado { get => tipoEmpleado; }

        public void SetHorasDiariasATrabajar(int horas)
        {
            this.horasDiarias = horas;
        }

        public void SetNumeroDeCuenta(string cuenta)
        {
            this.cuentaBancaria = cuenta;
        }

        public void SetPrecioHora(double precio)
        {
            this.precioPorHora = precio;
        }
    }
}