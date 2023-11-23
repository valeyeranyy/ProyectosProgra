using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour
{
    public Personaje heroe;
    private Animator miAnimador;
    public int puntosVeneno = 10;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D trigger)

    {
        //se muestra en consola la leyenda
        print(name + "hizo colision con" + trigger.gameObject.name);
        GameObject otro = trigger.gameObject;
        if (otro.tag == "Player")
        {
            miAnimador.SetTrigger("OBTENIENDO");
            GetComponent<Collider2D>().enabled = false;
            InvokeRepeating("Envenenado", 3, 1);
            Destroy(gameObject, 3);
        }
    }
    public void Envenedado()
    { 
        heroe.hp = heroe.hp - puntosVeneno;
    }
}
