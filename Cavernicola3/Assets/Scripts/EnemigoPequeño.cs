using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPequeño : MonoBehaviour
{
    public float velocidadCaminar = 3;
    private Rigidbody2D MiCuerpo;
    public float distanciaAgro = 5;
    private GameObject heroe;
    private Animator miAnimador;
    public int puntosDanio = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        MiCuerpo = GetComponent<Rigidbody2D>();
        heroe = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()

    {
        float velActualVert = MiCuerpo.velocity.y;
        Vector3 posHeroe = heroe.transform.position;
        Vector3 posYo = this.transform.position;
        //lo que esta entre parentesis calcula el vector. Despues de los parentesis, es decir, la magnitud calcula la distancia de ese vector
        float distancia = (posYo - posHeroe).magnitude;
        if (distancia < distanciaAgro)
        { //el heroe esta dentro de la zona de agro
            if (posHeroe.x > posYo.x)
            {
                MiCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
                transform.rotation = Quaternion.Euler(0, 0, 0);
                miAnimador.SetBool("CAMINANDO", true);
            }   
            else
            {
                MiCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
                transform.rotation = Quaternion.Euler(0, 180, 0);
                miAnimador.SetBool("CAMINANDO", true);
            }
        }
        else
        { //el heroe esta fuera de la zona de agro

            MiCuerpo.velocity = new Vector3(0, 0, 0);
            miAnimador.SetBool("CAMINANDO", false);
        }
    }
}
