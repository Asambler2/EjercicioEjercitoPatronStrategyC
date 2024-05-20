using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.ElAtaque
{
    public class SinAtaque : IPotencia
    {
        public string Mostrar()
        {
            return $"ATAQUE[Sin ataque]";
        }
    }
}
