using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.LaVelocidad
{
    public class Andando : IVelocidad, IValorVelocidad
    {
        public string Nombre = "Andando";
        public int Velocidad { get; set; }  = 10;
        public string Mostrar()
        {
            return $"VELOCIDAD[Nombre: {this.Nombre} y Velocidad: {this.Velocidad}]";
        }
    }
}
