using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.ElBlindaje
{
    public class Acorazado : IBlindaje, IValorBlindaje
    {
        public string Nombre = "Acorazado";
        public int Blindaje { get; set; }  = 30;
        public string Mostrar()
        {
            return $"BLINDAJE[Nombre: {this.Nombre} y Blindaje: {this.Blindaje}]";
        }
    }
}
