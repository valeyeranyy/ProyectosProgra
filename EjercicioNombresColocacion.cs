/*
En este ejercicio practicarás el nombre de las cosas
y su ubicación dentro del código.
Por cada línea que tenga una declaración de namespace,
clase, método, atributo, parámetro, variable, así como 
en ciclos y bloques condicionales, deberás indicar con un comentario 
qué es lo que se está declarando y dentro de qué bloque está.

No copies y pegues, debes transcribir.
NO: class Elefante
SI: clase Elefante

Observa con atención los primeros ejemplos.
*/

using System;//El using no es una declaración

namespace Ejemplos//Declaración de espacio de nombres Ejemplos
{
    class Elefante//Declaración de clase Elefante dentro de namespace Ejemplos
    {
        public string Nombre;//Declaración de atributo Nombre dentro de clase Elefante
        public int Edad;//Declaración de atributo Edad dentro de la clase Elefante
        public float Peso;//Declaración de atributo Peso dentro de la clase Elefante

        //Declaración de método Comer dentro de clase Elefante
        //Declaración de parámetro comida dentro de método comer
        public void Comer(string comida)
        {
            
            for(int i = 0; i < 10; i++)//Ciclo for dentro de método Comer
            {
                int porcionesComidas = i + 1;//Declaración de variable local porcionesComidas dentro de ciclo for
            }
            Console.WriteLine($"{Nombre} está comiendo {comida}.");//Esta línea no llevará comentario
        }

        public void Rugir() //Declaración de método Rugir dentro de la clase Elefante 
        {
            int distanciaEscuchante = 100; // Declaración de variable local distanciaEscuchante dentro del método Rugir
            Console.WriteLine($"{Nombre} está rugiendo.");
        }

        public void Dormir(int horas)//Declaración de método Dormir dentro de la clase Elefante / Declaración de parámetro horas dentro del método Dormir 
        {
            if(horas > 10) // Condicional if dentro del método Dormir  
            {
                float energiaGanada = 15; // Declaración de variable local energíaGanada dentro de la condicional if 
            }
            Console.WriteLine($"{Nombre} está durmiendo durante {horas} horas.");
        }
    }

    class Zapatero //Declaración de clase Zapatero dentro de namespace Ejemplos
    {
        public string Nombre; //Declaración de atributo Nombre dentro de clase Zapatero
        public string Especialidad; //Declaración de atributo Especialidad dentro de clase Zapatero
        public int AñosExperiencia; //Declaración de atributo AñosExperiencia dentro de clase Zapatero

        public void RepararZapatos(string tipo, int cantidad) // Declaración de método RepararZapatos dentro de la clase Zapatero / Declaración de parámetro tipo y cantidad dentro del método RepararZapatos 
        {
            int precio = 50; //Declaración de variable precio dentro del método RepararZapatos
            if (tipo == "tenis") //Condicional if dentro del método RepararZapatos
            {
                precio = 100;//Declaración de variable local precio dentro de condicional if 
            }
            Console.WriteLine($"{Nombre} está reparando {cantidad} zapatos de tipo {tipo} a precio {precio}");
        }

        public void CrearZapato(string estilo, string material) // Declaración de método CrearZapato dentro de la clase Zapatero / Declaración de parámetro estilo y material dentro del método CrearZapato 
        {
            for(int i = 0; i < 100; i++)//Ciclo for dentro del método CrearZapato
            {
                if(estilo == "industrial")//Condicional if dentro de ciclo for 
                {
                    Console.WriteLine("Golpeando fuerte");
                }
                else//Condicional else dentro de ciclo for 
                {
                    Console.WriteLine("Golpeando normal");

                }
            }
            Console.WriteLine($"{Nombre} está creando un zapato de estilo {estilo} con material {material}.");
        }

        public void MedirPie(int numeroPie)// Declaración de método MedirPie dentro de la clase Zapatero / Declaración de parámetro numeroPie dentro del método MedirPie
        {
            string cliente; // Declaración de variable cliente dentro del método MedirPie 
            if (numeroPie > 20) //Condicional if dentro del método MedirPie
            {
                cliente = "Adulto";// Declaración de variable local cliente dentro de condicional if 
            }
            else //Condicional else dentro del método MedirPie
            {
                cliente = "Niño"; // Declaración de variable local cliente dentro de condicional else
            }
            Console.WriteLine($"{Nombre} está midiendo el pie para el número {numeroPie}.");
        }
    }

    class Television //Declaración de clase Televisión dentro de namespace Ejemplos
    {
        public string Marca; //Declaración de atributo Marca dentro de clase Televisión
        public int Pulgadas;//Declaración de atributo Pulgadas dentro de clase Televisión
        public bool Encendida;//Declaración de atributo Encendida dentro de clase Televisión

        public void Encender()//Declaración de método Encender dentro de la clase Televisión 
        {
            Encendida = true; // Declaración de valor de variable Encendida dentro del método Encender
            float consumoLuz = 0.05f; //Declaración de variable consumoLuz dentro del método Encender
            Console.WriteLine($"La televisión de {Pulgadas} pulgadas, marca {Marca}, está encendida.");
        }

        public void CambiarCanal(int canal)//Declaración de método CambiarCanal dentro de la clase Televisión / Declaración de parámetro local canal dentro del método CambiarCanal 
        {
            for(int i = 1; i < canal; i++)//Ciclo for dentro del método CambiarCanal
            {
                Console.WriteLine($"Cambiando a canal {i}.");
            }            
        }

        public void AjustarVolumen(int nivel)//Declaración de método AjustarVolumen dentro de la clase Televisión / Declaración de parámetro local nivel dentro del método CambiarCanal
        {
            if (nivel > 100)//Condicional if dentro del método AjustarVolumen
            {
                nivel = 0; //Declaración de variable local nivel dentro de condicional if 
            }
            Console.WriteLine($"Ajustando el volumen a nivel {nivel}.");
        }
    }

    class Guitarra //Declaración de clase Guitarra dentro de namespace Ejemplos
    {
        public string Marca; //Declaración de atributo Marca dentro de clase Guitarra
        public string Tipo; //Declaración de atributo Tipo dentro de clase Guitarra
        public int Cuerdas;//Declaración de atributo Cuerdas  dentro de clase Guitarra

        public void TocarCuerda(int numeroCuerda) //Declaración de método TocarCuerda dentro de la clase Guitarra / Declaración de parámetro local numeroCuerda dentro del método TocarCuerda
        {
            if(numeroCuerda == 6)//Condicional if dentro del mètodo TocarCuerda
            {
                string nota = "Mi";//Declaraciòn de variable local nota dentro de condicional if
            }
            else if (numeroCuerda == 5)//Condicional else dentro del mètodo TocarCuerda
            {
                string nota = "La";//Declaraciòn de variable local nota dentro de condicional else
            }
            Console.WriteLine($"Tocando la cuerda {numeroCuerda} de la guitarra {Marca}.");
        }

        public void AfinarGuitarra(bool afinada) //Declaración de método AfinarGuitarra dentro de la clase Guitarra / Declaración de parámetro local afinada dentro del método AfinarGuitarra
        {
            if (afinada)//Condicional if dentro del método AfinarGuitarra
            {
                Console.WriteLine($"La guitarra {Marca} está afinada.");
            }
            else //Condicional else dentro del método AfinarGuitarra
            {
                for(int i = 0; i < 5; i++)//Ciclo for dentro de condicional else
                {
                    Console.WriteLine($"Afinando la guitarra {Marca}.");
                }                
            }
        }

        public void CambiarTipo(string nuevoTipo) //Declaración de método CambiarTipo dentro de la clase Guitarra / Declaración de parámetro local nuevoTipo dentro del método CambiarTipo
        {
            Tipo = nuevoTipo; //Declaración de variable local nuevoTipo dentro del método CambiarTipo
            Console.WriteLine($"Cambiando el tipo de la guitarra a {nuevoTipo}.");
        }
    }

}
