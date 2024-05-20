using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.LaVelocidad
{
    public class Motor : IVelocidad, IValorVelocidad
    {
        public string Nombre = "Motor";
        public int Velocidad { get; set; }  = 30;
        public string Mostrar()
        {
            return $"VELOCIDAD[Nombre: {this.Nombre} y Velocidad: {this.Velocidad}]";
        }
    }
}
