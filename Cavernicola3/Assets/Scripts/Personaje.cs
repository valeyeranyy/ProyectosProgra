using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Personaje : MonoBehaviour
{
    public int hp = 60;
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
       

        aturdido = true;
        if (hp <= 0)
        {
            muerto = true;
            vidas--;
            hp = 0;
            Personaje elPerso = GetComponent<Personaje>();
            elPerso.perderVida(puntosVida, this.gameObject);
            miAnimador.SetBool("Morir", true);
        }
        else (hp >= 1);


            //programo que se ejecute el metodo
            //desaturdir dentro de 1 segundo
            Invoke("desaturdir", 1);
       
    }
    //creo metdodo nuevo para que no este siempre aturdido mi personaje
    private void desaturdir()
    {
        aturdido = false;
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
        misSonidos.reproducir("MATAR");

    }
       
}

