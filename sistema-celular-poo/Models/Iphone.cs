﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_celular_poo.Models
{
    class Iphone : Smartphone
    {
        public Iphone(string definirNumero, string definirModelo, string definirImei, int definirMemoria) : base(definirNumero, definirModelo, definirImei, definirMemoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando '{nomeApp}' no Iphone.");
        }
    }
}
