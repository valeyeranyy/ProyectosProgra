using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Personaje : MonoBehaviour
{
    public int hp = 30;
    public int hpMax = 100;
    public int score = 0;
    public int vidas = 3;
    public int puntosVida = 10;
    public bool aturdido = false;
    public bool muerto = false;
    public GameObject efectoSangrePrefab;
    private Animator miAnimador;
    private ReproductorSonidos misSonidos;

    void Start()
    {
        miAnimador=GetComponent<Animator>(); 
        misSonidos = GetComponent<ReproductorSonidos>();
    }
    public void hacerDanio(int puntos, GameObject atacante)
    {
        print(name + "recibe daño de"
            + puntos + "por" + atacante.name);
        //resto los puntos al HP actual
        hp = hp - puntos;
        //activo el trigger llamdo dañar en el animator
        miAnimador.SetTrigger("Dañar");
        GameObject sangre = Instantiate(efectoSangrePrefab, transform);
        misSonidos.reproducir("DAÑAR");
        //comando que programa que se ejecute el metodo
        //desaturdir dentro de 1 segundo
        Invoke("desaturdir", 4);

        aturdido = true;
        //si mi hp llega a cero, invoco el metodo perderVida
        if (hp <= 0 &&vidas>0)
        {   
            Personaje elPerso = GetComponent<Personaje>();
            elPerso.matar(this.gameObject);
        }  
        else if (hp<=0&&vidas>0)
        {
            vidas--;
            muerto = true;

        }

    }
   
    public void perderVida(int puntosVida, GameObject atacante)
    {
        print(name + "Muere por " + atacante.name);
        //tambien se puede escribir como:
        //vidas=vidas -1 
        //vidas - =1;
        //vidas--;
        vidas = vidas - puntosVida;
        hp = 0;
        //creo una instancia de la parte de sangre
        GameObject sangre = Instantiate(efectoSangrePrefab,transform);
        miAnimador.SetTrigger("Morir");
        misSonidos.reproducir("Morir");

        muerto = true;
    }
    //creo metdodo nuevo para que no este siempre aturdido mi personaje
    private void desaturdir()
    {
        aturdido = false;
    }
    public void matar(GameObject atacante)
    {
        print(name + "Muere por " + atacante.name);
        vidas = 0;
        hp = 0;
        miAnimador.SetTrigger("MATAR");
        misSonidos.reproducir("MATAR");

        muerto = true;
    }
}

