﻿using EjercicioFactoriaEjercitoC.ElAtaque;
using EjercicioFactoriaEjercitoC.ElBlindaje;
using EjercicioFactoriaEjercitoC.LaVelocidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.Unidades
{
    public class Unidad : IMilitarizable, ICosteable
    {
        public string Titulo { get; set; }
        public IVelocidad Velocidad { get; set; }
        public IBlindaje Blindaje { get; set; }
        public IPotencia PotenciaFuego { get; set; }
        public float Precio { get; set; }

        public Unidad (string titulo, IVelocidad velocidad, IBlindaje blindaje, IPotencia potenciaFuego, float precio)
        {
            Titulo = titulo;
            Velocidad = velocidad;
            Blindaje = blindaje;
            PotenciaFuego = potenciaFuego;
            Precio = precio;
        }

        public string Mostrar()
        {
            return $"Unidad: {this.Titulo} con velocidad: {this.Velocidad.Mostrar()}, blindaje: {this.Blindaje.Mostrar()}, potencia de fuego: {this.PotenciaFuego.Mostrar()} y precio: {this.Precio}";
        }
    }
}
