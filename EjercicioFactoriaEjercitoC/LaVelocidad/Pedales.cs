﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.LaVelocidad
{
    public class Pedales : IVelocidad
    {
        public string Nombre = "Pedales";
        public int Velocidad = 20;
        public string Mostrar()
        {
            return $"VELOCIDAD[Nombre: {this.Nombre} y Velocidad: {this.Velocidad}]";
        }
    }
}
