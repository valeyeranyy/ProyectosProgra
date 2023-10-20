using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerte : MonoBehaviour
{
    //declaro variable
    public int puntosVida = 1;
    public GameObject efectoSplashPrefab;
    private ReproductorSonidos misSonidos;
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        //se muestra en consola la leyenda
        print(name + "hizo colision con" + trigger.gameObject.name);
        GameObject otro = trigger.gameObject;
        if (otro.tag == "Player")
        {
            //Accede al componente de tipo Personaje del objeto con el que choque
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplico el daño al otro invocando el metodo hacer daño
            elPerso.perderVida(puntosVida, this.gameObject);
            //aplico splash de sangre
            GameObject Splash = Instantiate(efectoSplashPrefab, elPerso.transform);
            misSonidos.reproducir("SPLASH");
        }
    }
}