using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.ElBlindaje
{
    public class Acolchado : IBlindaje
    {
        public string Nombre = "Acolchado";
        public int Blindaje = 10;
        public string Mostrar()
        {
            return $"BLINDAJE[Nombre: {this.Nombre} y Blindaje: {this.Blindaje}]";
        }
    }
}
