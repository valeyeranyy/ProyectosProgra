using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguidora : MonoBehaviour
{
    //este es un atributo de la clase
    //que funciona compo referencia a
    //la pelota
    public Transform Pelota;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//le coloco la posicion de la pelota a la camara, excepto en z
        transform.position =
             new Vector3(
                 Pelota.position.x,
                 Pelota.position.y,
                 -1);
    }
}
