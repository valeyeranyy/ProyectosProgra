using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocion : MonoBehaviour
{
    public Personaje heroe;
    private Animator miAnimador;
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
            heroe.hp = heroe.hpMax;
            miAnimador.SetTrigger("OBTENIENDO");
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 3);
        }
    }
}
