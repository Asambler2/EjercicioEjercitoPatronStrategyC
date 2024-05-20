using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.ElBlindaje
{
    public class Placas : IBlindaje
    {
        public string Nombre = "Placas";
        public int Blindaje = 20;
        public string Mostrar()
        {
            return $"BLINDAJE[Nombre: {this.Nombre} y Blindaje: {this.Blindaje}]";
        }
    }
}
