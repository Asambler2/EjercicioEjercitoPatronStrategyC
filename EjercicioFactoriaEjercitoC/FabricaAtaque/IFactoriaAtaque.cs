using EjercicioFactoriaEjercitoC.ElAtaque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaAtaque
{
    public interface IFactoriaAtaque
    {
        public IPotencia DameAtaque();
    }
}
