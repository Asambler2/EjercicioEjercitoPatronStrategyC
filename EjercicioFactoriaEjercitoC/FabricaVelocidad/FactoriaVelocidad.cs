using EjercicioFactoriaEjercitoC.LaVelocidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaVelocidad
{
    public class FactoriaVelocidad : IFactoriaVelocidad
    {
        public IVelocidad DameVelocidad()
        {
            int Comando = 0;
            Console.WriteLine("Pulsa 1 para elegir sin velocidad");
            Console.WriteLine("Pulsa 2 para elegir andando");
            Console.WriteLine("Pulsa 3 para elegir bicicleta");
            Console.WriteLine("Pulsa 4 para elegir motor");

            Comando = int.Parse(Console.ReadLine());

            switch (Comando)
            {
                case 1: return new SinMovimiento();
                case 2: return new Andando();
                case 3: return new Pedales();
                case 4: return new Motor();
                default: return new SinMovimiento();
            }
        }
    }
}
