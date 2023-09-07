using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    public class Program
    {
        static void Main(string[] args)
        {
            AutoCarreras ferrari = new AutoCarreras();
            ferrari.modelo = "Ferrari F150";
            ferrari.peso = 1.3f;
            ferrari.velocidad = 230;

            AutoCarreras mcLaren = new AutoCarreras();
            mcLaren.modelo = "McLaren A45S";
            mcLaren.peso = 0.98f;
            mcLaren.velocidad = 280;//sonkm/h

            PistaCarreras hnsRodriguez = new PistaCarreras();
            hnsRodriguez.nombre = "Autodromo Hermanos Rofriguez";
            hnsRodriguez.longitud = 5.6f;
            //Mando a competir a mis coches
            hnsRodriguez.Competir(ferrari, mcLaren);

            ferrari.PonerGas(20);
            ferrari.Acelerar(30);
            ferrari.Arrancar();
            ferrari.Frenar();
            //Esta instruccion espera a que des enter para contnuar
            Console.ReadLine();

        }
    }
}
