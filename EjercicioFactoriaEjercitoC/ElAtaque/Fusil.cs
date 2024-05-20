using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.ElAtaque
{
    public class Fusil : IPotencia, IValorPotencia
    {
        public string Nombre = "Fusil";
        public int Potencia { get; set; } = 20;
        public string Mostrar()
        {
            return $"ATAQUE[Nombre: {this.Nombre} y Potencia: {this.Potencia}]";
        }
    }
}
