﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeNombres
{
    class Program
    {
        GeneradorDeNombresVillano generador =
              new GeneradorDeNombresVillano();

        generador.generar(15);
            Console.Read();
    }
}
