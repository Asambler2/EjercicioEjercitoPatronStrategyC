using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.ElAtaque
{
    public class Pistola : IPotencia
    {
        public string Nombre = "Pistola";
        public int Potencia = 10;
        public string Mostrar()
        {
            return $"ATAQUE[Nombre: {this.Nombre} y Potencia: {this.Potencia}]";
        }
    }
}
