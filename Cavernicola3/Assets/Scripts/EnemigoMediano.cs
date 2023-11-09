using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMediano : MonoBehaviour
{
    public float velocidadCaminar = 3;
    private Rigidbody2D MiCuerpo;
    public float distanciaAgro = 5;
    public float distanciaAgroCorta = 3;
    private GameObject heroe;
    private Animator miAnimador;
    public int puntosDanio = 10;
    public GameObject efectoGolpePrefab;
    // Start is called before the first frame update
    void Start()
    {
        //miCollider=GetCompinent<CapsuleCollider2D>();
        heroe = GameObject.FindWithTag("Player");
        MiCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posHeroe = heroe.transform.position;
        Vector3 posYo = this.transform.position;

        float distancia = (posYo - posHeroe).magnitude;
        float velActualVert = MiCuerpo.velocity.y;

        if (distancia < distanciaAgro & distancia > distanciaAgroCorta)
        { //el heroe esta fuera de la zona de agro
            if (posHeroe.x > posYo.x)
            {
                //el heroe derecha villano
                transform.rotation = Quaternion.Euler(0, 0, 0);
                MiCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
                miAnimador.SetBool("CAMINANDO", true);
                miAnimador.SetBool("ATACANDO", false);
            }
            else
            {
                //el heroe izquierda villano
                transform.rotation = Quaternion.Euler(0, 180, 0);
                MiCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
                miAnimador.SetBool("CAMINANDO", true);
                miAnimador.SetBool("ATACANDO", false);
            }
        }
        else if (distancia < distanciaAgro && distancia < distanciaAgroCorta)
        {
            if (posHeroe.x > posYo.x)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                MiCuerpo.velocity = new Vector3(0, 0, 0);
                miAnimador.SetBool("ATACANDO", true);
                miAnimador.SetBool("CAMINANDO", false);
                //miCollider.size = new Vector2(2.7f, 1.2f);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                MiCuerpo.velocity = new Vector3(0, 0, 0);
                miAnimador.SetBool("CAMINANDO", false);
                miAnimador.SetBool("ATACANDO", true);
                //miCollider.size = new Vector2(2.7f, 1.2f);
            }
        }
        else
        {//el heroe esta fuera de la zona de agro
            transform.rotation = Quaternion.Euler(0, 0, 0);
            MiCuerpo.velocity = new Vector3(0, 0, 0);
            miAnimador.SetBool("CAMINANDO", false);
            miAnimador.SetBool("ATACANDO", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(name + "hizo colisionm con" + collision.gameObject.name);
        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            //Accede al componente de tipo Personaje del objeto con el que choqué
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplica el daño al otro invocando el metodo hacer daño
            elPerso.hacerDanio(puntosDanio, this.gameObject);
            Instantiate(efectoGolpePrefab, elPerso.transform);
        }
    }
}
