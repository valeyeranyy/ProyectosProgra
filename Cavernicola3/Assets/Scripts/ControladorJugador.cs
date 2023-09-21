using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidadCaminar = 3;
    public float fuerzaSalto = 20;
    public bool enPiso = false;//Grounded
    private Rigidbody2D MiCuerpo;
    private Animator miAnimador;
    
    
    // Start is called before the first frame update
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()

    {
        //la comprobacion de piso es lo primero que se hace cada frame
        comprobarPiso();

        float velActualVert = MiCuerpo.velocity.y;
        float movHoriz = Input.GetAxis("Horizontal");
        if (movHoriz > 0)
        {                                        //x  y  z
            transform.rotation = Quaternion.Euler(0, 0, 0);
            MiCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("CAMINANDO", true);
        }
        else if (movHoriz < 0)//a la izquierda
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            MiCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("CAMINANDO", true);
        }
        else 
        {
            MiCuerpo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("CAMINANDO", false);
        }
        if (Input.GetButtonDown("Jump"))
        {
            if (enPiso)
            {
                MiCuerpo.AddForce(
                new Vector3(0, fuerzaSalto, 0),
                ForceMode2D.Impulse);
            }
            else if (enPiso==false)
            {
               
            }
        }
        miAnimador.SetFloat("vel_vert", velActualVert);
        

    }

    void comprobarPiso()
    {
        //lanzo un rayo de deteccion de colisiones hacoia abajo desde la posicion del este objeto (cavernicula)
        enPiso = Physics2D.Raycast(
            transform.position, //desde donde
            Vector2.down,//hacia abajo
            0.1f//distancia
            );
    }
}
