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
        private string medioDePago;
        private int horasDiarias = 9;
        private string tipoEmpleado = "Temporal";

        public string Nombre { get => nombre; set => nombre = value; }
        public double PrecioPorHora { get => precioPorHora; set => precioPorHora = value; }
        public string MedioDePago { get => medioDePago; set => medioDePago = value; }
        public int HorasDiarias { get => horasDiarias; set => horasDiarias = value; }
        public string TipoEmpleado { get => tipoEmpleado;  }

        public void SetHorasDiariasATrabajar(int horas)
        {
            this.horasDiarias = horas;
        }

        public void SetPrecioHora(double precio)
        {
            this.precioPorHora = precio;
        }
    }
}
