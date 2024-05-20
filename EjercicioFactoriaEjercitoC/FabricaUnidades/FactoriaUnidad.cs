using EjercicioFactoriaEjercitoC.ElAtaque;
using EjercicioFactoriaEjercitoC.ElBlindaje;
using EjercicioFactoriaEjercitoC.FabricaVelocidad;
using EjercicioFactoriaEjercitoC.FabricaBlindaje;
using EjercicioFactoriaEjercitoC.FabricaAtaque;
using EjercicioFactoriaEjercitoC.LaVelocidad;
using EjercicioFactoriaEjercitoC.Unidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaUnidades
{
    public class FactoriaUnidad : IFactoriaUnidad
    {
        public IMilitarizable DameUnidad()
        {
            string NombreUnidad = "";
            IVelocidad Velocidad;
            IBlindaje Blindaje;
            IPotencia PotenciaFuego;
            float Precio = 0;
            Console.WriteLine("Escribe el nombre de la unidad");
            NombreUnidad = Console.ReadLine();
            Console.WriteLine("Escribe la velocidad de la unidad");
            IFactoriaVelocidad LaFabricaVelocidad = new FactoriaVelocidad();
            Velocidad = LaFabricaVelocidad.DameVelocidad();
            Console.WriteLine("Escribe el blindaje de la unidad");
            IFactoriaBlindaje LaFabricaBlindaje = new FactoriaBlindaje();
            Blindaje = LaFabricaBlindaje.DameBlindaje();
            Console.WriteLine("Escribe la potencia de fuego de la unidad");
            IFactoriaAtaque LaFabricaAtaque = new FactoriaAtaque();
            PotenciaFuego = LaFabricaAtaque.DameAtaque();
            Console.WriteLine("Escribe el precio de la unidad");
            Precio = float.Parse(Console.ReadLine());
            return new Unidad(NombreUnidad, Velocidad, Blindaje, PotenciaFuego, Precio);
        }
    }
}
