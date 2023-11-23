using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesoroMoneda : MonoBehaviour
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
            heroe.score++;
            miAnimador.SetTrigger("OBTENIENDO");
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 3);
        }
    }
}
