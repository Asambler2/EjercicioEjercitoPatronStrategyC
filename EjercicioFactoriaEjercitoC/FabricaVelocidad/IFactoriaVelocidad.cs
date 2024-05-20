using EjercicioFactoriaEjercitoC.LaVelocidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaVelocidad
{
    public interface IFactoriaVelocidad
    {
        public IVelocidad DameVelocidad();
    }
}
