using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    public class AutoCarreras
    {
        public string modelo;
        public float peso;
        public int velocidad;
        public float gasolina;

        public void PonerGas(float cantidad)
        {
            gasolina = gasolina + cantidad;
            Console.WriteLine(modelo + "tiene" + gasolina + "1 de gas");
        }

        public void Arrancar()
        {
            if (gasolina > 0)
            {   //Consume 0.01 litros de gas cada que arranca
                gasolina = gasolina - 0.01f;
                Console.WriteLine("Arrancando" + modelo + "le quedan" + gasolina + "1 de gas.");
            }
            else
            {
                Console.WriteLine("No se pudo arrancar " + modelo + "sin gasolina.");
            }

        }

        public void Acelerar (int aceleracion)
        {
            gasolina = velocidad - velocidad / 10f;
            velocidad = velocidad + aceleracion;
            if (gasolina < 0)
            {
                Console.WriteLine(modelo + "se ha quedado sin gasolina");
            }
            else
            {
                Console.WriteLine(modelo + "aceleró hasta " + velocidad + "km por hora");
            }

        }
        public void Frenar()
        {
            if (velocidad > 0)
            {
                velocidad = 0;
                Console.WriteLine(modelo + "ha frenado");
            }
            else
            {
                Console.WriteLine(modelo + "ya esta frenado.");
            }
        }
    }       
}
