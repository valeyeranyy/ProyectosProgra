using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]diasSemana = { "Domingo", "lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
            int cantDias = diasSemana.Length;
            Console.WriteLine("Hay" + cantDias + "dias en el arreglo");

            //Asignar un valor en el arreglo
            diasSemana[1] = "Monday";

            //Accedo a un elemento y lo guardo en variable
            string diaUno = diasSemana[1];
            string diaTres = diasSemana[3];

            Console.WriteLine(diaUno);
            Console.WriteLine(diaTres);
            Console.WriteLine(diasSemana[0]);
            Console.WriteLine(diasSemana[4]);

            for (int i = 0; i < 7; i++); //esto es un hardcodeado. No usar este
            {

            }
            for (int i = 0; diasSemana.Length; i++);//esto es un parametrizado. si usar este
            {
                //Uso la variable de control i para acceder a cada elemento del arraglo
                Console.WriteLine(i + ".-" + diasSemana[i]);

            }
            Console.ReadLine();
        }     
    }
}
