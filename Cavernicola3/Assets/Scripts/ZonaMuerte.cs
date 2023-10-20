using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerte : MonoBehaviour
{
    public int puntosVida = 1;
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        print(name + "hizo colision con" + trigger.gameObject.name);
        GameObject otro = trigger.gameObject;
        if (otro.tag == "Player")
        {
            //Accede al componente de tipo Personaje del objeto con el que choqu�
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplico el da�o al otro invocando el metodo hacer da�o
            elPerso.perderVida(puntosVida, this.gameObject);
        }
    }
}