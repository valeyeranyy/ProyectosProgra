using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musica
{
    class Program
    {
        static void Main(string[] args)
        {
           
                artista Roxette = new artista();
                Roxette.nombredelartista = "Roxette";
                Roxette.miembros = "Marie Fredrikson, " +
                    "Per Gessle";
                Roxette.generosdelartista = "Rock, rock alternativo, " +
                    "pop rock y dance";
                Roxette.albums = "Joyride, Look Sharp, ";
                Roxette.periododeactividad = 1988 - 2019;

                album Wave = new album();
                Wave.nombredelalbum = "Wave";
                Wave.anodepulicacion = 1991;
                Wave.generosdelalbum = "artpop, y electrónica";
                Wave.duraciondelalbum = 39.13f;
                Wave.diseñodelacaratuladelalbum = "olas del mar";

                cancion TheLook = new cancion();
                TheLook.nombre = "Repetition";
                TheLook.duracion = 4.45f;
                TheLook.generos = "pop, rock";
                TheLook.numerodepista = 7;
                TheLook.compositores = "Marie Fredrikson";


                artista U2 = new artista();
                U2.nombredelartista = "U2";
                U2.miembros = "Bono, TheEdge, y Larry Mullen";
                U2.generosdelartista = "rock";
                U2.albums = "The Joshua Tree, songs of surrender ";
                U2.periododeactividad = 1976 - 2023;

                album TheJoshuaTree = new album();
                TheJoshuaTree.nombredelalbum = "The Joshua Tree";
                TheJoshuaTree.anodepulicacion = 1987;
                TheJoshuaTree.generosdelalbum = "rock";
                TheJoshuaTree.duraciondelalbum = 60.32f;
                TheJoshuaTree.diseñodelacaratuladelalbum = "miembros de la banda";

                cancion Exit = new cancion();
                Exit.nombre = "Exit:Exit:";
                Exit.duracion = 4.21f;
                Exit.generos = "indie rock, rock";
                Exit.numerodepista = 6;
                Exit.compositores = "Bono";


                artista Ruel = new artista();
                Ruel.nombredelartista = "Ruel";
                Ruel.miembros = "Ruel Vincent ";
                Ruel.generosdelartista = "pop";
                Ruel.albums = "Free time, ready y 4th wall";
                Ruel.periododeactividad = 2015 - 2023;

                album Campus = new album();
                Campus.nombredelalbum = "Campus";
                Campus.anodepulicacion = 2019;
                Campus.generosdelalbum = "pop, indie pop";
                Campus.duraciondelalbum = 46.19f;
                Campus.diseñodelacaratuladelalbum = "planta sobre mesa";

                cancion Pain = new cancion();
                Pain.nombre = "Pain Killer";
                Pain.duracion = 2.49f;
                Pain.generos = "pop";
                Pain.numerodepista = 6;
                Pain.compositores = "Ruel Vincent";
            
        }
    }
}
    

