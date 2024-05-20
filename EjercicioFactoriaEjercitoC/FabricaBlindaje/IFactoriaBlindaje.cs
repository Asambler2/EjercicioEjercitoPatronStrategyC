using EjercicioFactoriaEjercitoC.ElBlindaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaBlindaje
{
    public interface IFactoriaBlindaje
    {
        public IBlindaje DameBlindaje();
    }
}
