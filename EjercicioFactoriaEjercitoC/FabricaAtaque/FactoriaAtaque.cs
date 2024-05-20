using EjercicioFactoriaEjercitoC.ElAtaque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaAtaque
{
    public class FactoriaAtaque : IFactoriaAtaque
    {
        public IPotencia DameAtaque()
        {
            int Comando = 0;
            Console.WriteLine("Pulsa 1 para elegir sin ataque");
            Console.WriteLine("Pulsa 2 para elegir pistola");
            Console.WriteLine("Pulsa 3 para elegir fusil");
            Console.WriteLine("Pulsa 4 para elegir no cañon");

            Comando = int.Parse(Console.ReadLine());

            switch(Comando)
            {
                case 1: return new SinAtaque();
                case 2: return new Pistola();
                case 3: return new Fusil();
                case 4: return new Cannon();
                default: return new SinAtaque();
            }
        }
    }
}
