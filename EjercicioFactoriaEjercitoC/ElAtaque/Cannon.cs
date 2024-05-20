using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.ElAtaque
{
    public class Cannon: IPotencia, IValorPotencia
    {
        public string Nombre = "Cañon";
        public int Potencia { get; set; }  = 30;
        public string Mostrar()
        {
            return $"ATAQUE[Nombre: {this.Nombre} y Potencia: {this.Potencia}]";
        }
    }
}
