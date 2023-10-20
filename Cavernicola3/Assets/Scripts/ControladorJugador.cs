using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidadCaminar = 3;
    public float fuerzaSalto = 20;
    public bool enPiso = false;//Grounded
    public float saltosMax = 2f;
    private float saltosRest;
    private Rigidbody2D MiCuerpo;
    private Animator miAnimador;
    private ReproductorSonidos misSonidos;
    
    
    // Start is called before the first frame update
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonidos>();
        saltosRest = saltosMax;
    }

    // Update is called once per frame
    void Update()
    {
        //La comprobacion de piso
        //es lo primero que hace
        comprobarPiso();

        float velActualVert = MiCuerpo.velocity.y;
        float movHoriz = Input.GetAxis("Horizontal");

        if (movHoriz > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            MiCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            //cavernicola.flipX = false;
            miAnimador.SetBool("CAMINANDO", true);
        }
        else if (movHoriz < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            MiCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
            //cavernicola.flipX = true;
            miAnimador.SetBool("CAMINANDO", true);
        }

        else
        {
            MiCuerpo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("CAMINANDO", false);
        }

        if (enPiso)//se reincia todo
        {
            saltosRest = saltosMax;//los saltos restantes se reinician a los maximos
        }

        if (Input.GetButtonDown("Jump") && saltosRest > 0)//Salto solo si mis saltos restantes son mayor a cero
        {
            saltosRest--;//hace que se le reste uno a los saltos restantes
            MiCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
        }

        miAnimador.SetFloat("vel_vert", velActualVert);

        

    }

    public void comprobarPiso()
    {
        //lanzo un rayo de deteccion de colisiones hacia abajo desde la posicion del este objeto (cavernicola)
        enPiso = Physics2D.Raycast(
        transform.position, //desde donde
            Vector2.down,//hacia abajo
            0.1f//distancia
            );
        misSonidos.reproducir("SALTAR");

    }
}
