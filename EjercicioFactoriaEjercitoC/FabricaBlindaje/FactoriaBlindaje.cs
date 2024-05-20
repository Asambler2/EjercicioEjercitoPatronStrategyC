using EjercicioFactoriaEjercitoC.ElBlindaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaBlindaje
{
    public class FactoriaBlindaje : IFactoriaBlindaje
    {
        public IBlindaje DameBlindaje()
        {
            int Comando = 0;
            Console.WriteLine("Pulsa 1 para elegir sin blindaje");
            Console.WriteLine("Pulsa 2 para elegir acolchado");
            Console.WriteLine("Pulsa 3 para elegir placas");
            Console.WriteLine("Pulsa 4 para elegir no acorazado");

            Comando = int.Parse(Console.ReadLine());

            switch (Comando)
            {
                case 1: return new SinBlindaje();
                case 2: return new Acolchado();
                case 3: return new Placas();
                case 4: return new Acorazado();
                default: return new SinBlindaje();
            }
        }
    }
}
