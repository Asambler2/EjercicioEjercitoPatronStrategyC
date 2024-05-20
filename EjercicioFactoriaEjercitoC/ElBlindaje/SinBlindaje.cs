using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.ElBlindaje
{
    public class SinBlindaje : IBlindaje
    {
        public string Mostrar()
        {
            return $"ATAQUE[Sin blindaje]";
        }
    }
}
