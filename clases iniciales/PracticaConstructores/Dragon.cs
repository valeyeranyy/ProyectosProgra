using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Dragon
    {
        private string tipo; = "hielo"
        private string color; = "gris"
        private int cantAlas; = 4;
        private int peso; = 25000;
        
        //despues de los atributos y antes de los metodos se ponene los constructores:
        public Dragon()
        {//este es un constructor
            //establezco el estado inicial del objeto

        }
                     //estos son parametros
        public Dragon(string valorTipo, string valorColor)
        {//este es otro constructor pero recibe parametros
            tipo = valorTipo; 
            color = valorColor

        }
        public void presentarse();
        {
           Console WriteLine("YO SOY UN DRAGON DE"
               + tipo + "color"
               + color
               + "y voy a comerlos a todos");
        public int calcVelocidadVuelo();
        {
          return peso / cantAlas;
        }
    }
}
      
        
           
   
