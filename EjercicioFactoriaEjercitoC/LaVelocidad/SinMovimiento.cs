using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.LaVelocidad
{
    public class SinMovimiento : IVelocidad
    {
        public string Mostrar()
        {
            return $"MOVIMIENTO[Sin movimiento]";
        }
    }
}
