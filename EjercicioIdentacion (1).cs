/*
INSTRUCCIONES

1. En cada una de las líneas del siguiente código
deberás colocar un comentario al final de la línea en el que 
indiques  el nivel de identación de la siguiente manera: //Identacion: #
donde # es el nivel de identación.

2. Adicional al nivel de identación, en cada línea donde 
haya una llave de apertura deberás colocar un comentario 
que diga: //Inicio de bloque ... 
donde los 3 puntos indican a qué le pertenece, por ejemplo:
inicio de bloque de metodo1, inicio de bloque de claseA, 
inicio de ciclo for, etc.
Y, donde haya una llave de cierre, deberás colocar lo mismo, 
pero indicando //Fin de bloque ...

Observa algunas líneas de ejemplo que ya lo tienen.
Debes hacerlo para cada una de las líneas, excepto las que 
estén vacías.
*/
using System;

namespace ClasesYMetodosAnidados
{//Identacion: 0, Inicio de bloque de namespace ClasesYMetodosAnidados
	class Program //Identacion: 1
	{//identacion 1, Inicio de bloque de clase Program
		static void Main(string[] args)//Identacion: 2
		{//identacion 2, inicio de bloque de main
			ClaseA objetoA = new ClaseA();//Identacion: 3
			ClaseB objetoB = new ClaseB();//Identación: 3

			objetoA.Metodo1();//identacion: 3
			objetoA.Metodo2();//Identacion 3

			objetoB.Metodo1();//Identacion 3
			objetoB.Metodo2();//Identacion 3
		}//Identacion 2, fin  de metodo de main
	}//identacion 1, fin de bloque de clase Program

	class ClaseA//identacion 1
	{//identacion 1, inicio de bloque ClaseA
		public void Metodo1()//identacion 2
		{//identacion 2, inicio de bloque de Metodo1
			for (int i = 0; i < 3; i++)//identacion 3
			{//identacion 3, inicio de ciclo for
				Console.WriteLine("Método 1 de ClaseA - Iteración: " + i);7//identacion 4

				for (int j = 0; j < 2; j++)//identacion 4
				{//identacion 4, incio de ciclo for
					Console.WriteLine("Ciclo anidado - Iteración: " + j)//identacion 5
				}//identacion 4, fin de ciclo for
			}//identacion 3, fin de ciclo for
		}//identacion 2, fin de bloque de metodo1

		public void Metodo2()//identacion 2
		{//identacion 2, inicio de Metodo2
			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)//identacion 3
			{//identacion 3, inicio de bloque condicional if
				Console.WriteLine("Es fin de semana en Método 2 de ClaseA")//identacion 4
			}//identacionn 3, fin de bloque condicional if
			else//identacion 
			{//identacion 3, inicio de bloque condicional else
				Console.WriteLine("No es fin de semana en Método 2 de ClaseA");//identacion 4
			}//identacion 3, fin de bloque condicional else
		}//identacion 2, fin de Metodo2
	}//identacion 1, fin de bloque ClaseA

	class ClaseB//identacion 1
	{//identacion 1, inicio de bloque de ClaseB
		public void Metodo1()//identacion 2
		{//identacion 2, inicio de bloque de Metodo1
			for (int i = 5; i > 0; i--)//identacion 3
			{//identacion 3, inicio de ciclo for
				Console.WriteLine("Método 1 de ClaseB - Iteración: " + i);//identacion 4

				for (int j = 0; j < i; j++)//identacion 4
				{//identacion 4, inicio de ciclo for
					Console.WriteLine("Ciclo anidado - Iteración: " + j);//identacion 5
				}//identacion 4, fin de ciclo for
			}//identacion 3, fin de ciclo for
		}//identacion 2, fin de bloque Metodo1

		public void Metodo2()//identacion 2
		{//identacion 2, inicio de Metodo2
			int numero = 10;//identacion 3, atributo int

			if (numero % 2 == 0)//identacion 3, inicio de bloque condicional if
			{//identacion 3, inicio de bloque condicional if
				Console.WriteLine("El número es par en Método 2 de ClaseB");//identacion 4
			}//identacion 3, fin de bloque condicional if
			else
			{//identacion 3, inicio de condicional else
				Console.WriteLine("El número es impar en Método 2 de ClaseB");
			}//identacion 3, fin de condicional else
		}//identacion 2, fin de Metodo2
	}//identacion 1, fin de bloque de ClaseB
}//identacion 0, fin de bloque namespace ClasesYMetodosAnidados