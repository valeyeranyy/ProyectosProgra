using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeNombres
{
    public class GeneradorDeNombresDeVillanos
    {
        //estos son atributos        Enero 1       febrero 2    marzo 3
        public string[] titulos = { "The Black", "The Kid", "The wicked" };
        //0             1            2
        public string[] razas = { "gargola", "gnomo", "criatura" };
        public string[] origenes = { "of the night", "of the seas", "of the north" };

        //se declara un metodo dentro de la misma clase. Se llamara: generar
        public void generar(int mes);
        {
        if (mes > 12)
        {
        Console.Writeline("Los meses van del 1 al 12");
        }
    Console.WriteLine(titulo[mes]+"" + raza[dia] + origenes[color]);
        }
    }    
}