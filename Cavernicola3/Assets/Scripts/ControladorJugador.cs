using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//este controlador se comunica con el usuario
public class ControladorJugador : MonoBehaviour
{
    public float velocidadCaminar = 3f;
    public float fuerzaSalto = 20f;
    public bool enPiso = false;//Grounded
    public float saltosMax = 2f;
    private float saltosRest;
    private Rigidbody2D MiCuerpo;
    private Animator miAnimador;
    private ReproductorSonidos misSonidos;
    public int puntosDanio = 5;
    private Personaje miPersonaje;
    
    // Start is called before the first frame update
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonidos>();
        saltosRest = saltosMax;
        miPersonaje = GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
        //La comprobacion de piso
        //es lo primero que hace
        comprobarPiso();

        float velActualVert = MiCuerpo.velocity.y;
        float movHoriz = Input.GetAxis("Horizontal");
                         //y mi personaje no esta atrudido
        if (movHoriz > 0 && !miPersonaje.aturdido && !miPersonaje.muerto)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            MiCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            //cavernicola.flipX = false;
            miAnimador.SetBool("CAMINANDO", true);
           
        }
        else if (movHoriz < 0 && !miPersonaje.aturdido && !miPersonaje.muerto)
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

        if (Input.GetButtonDown("Jump") && saltosRest > 0  && !miPersonaje.aturdido && !miPersonaje.muerto)//Salto solo si mis saltos restantes son mayor a cero
        {
            saltosRest--;//hace que se le reste uno a los saltos restantes
            MiCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
            misSonidos.reproducir("SALTAR");
        }
        //spolo puedo atacar si presiono el boton de fire1
        if (Input.GetButtonDown("Fire1") && !miPersonaje.aturdido && !miPersonaje.muerto)
        {
            miAnimador.SetTrigger("atacar");

        }
       
        if(miPersonaje.hp<=0)
        {
            Invoke("morirPersonaje", 1.0f);
        }

    }
    public void morirPersonaje()
    {
        SceneManager.LoadScene(1);
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
    private void OnTriggerEnter2D(Collider2D trigger)

    {
        //se muestra en consola la leyenda
        print(name + "hizo colision con" + trigger.gameObject.name);
        GameObject otro = trigger.gameObject;
        if (otro.tag == "Enemigo")
        {
            //Accede al componente de tipo Personaje del objeto con el que choque
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplico el daño al otro invocando el metodo hacer daño
            elPerso.hacerDanio(puntosDanio, this.gameObject);

        }
    }

}

