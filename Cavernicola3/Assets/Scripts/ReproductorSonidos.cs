using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//anotacion que obliga al gameobject que tenga a este componenente tenga sonido
[RequireComponent(typeof(AudioSource))]
public class ReproductorSonidos : MonoBehaviour
{
    public EfectoSonoro[] efectos;
    private AudioSource miFuenteSonora;
    // Start is called before the first frame update
    void Start()
    {
        miFuenteSonora = GetComponent<AudioSource>();
    }
    public void reproducir(string accion)
    { for (int i = 0; i < efectos.Length;i++)
        {
            EfectoSonoro efecto = efectos[i];
            if (efecto.accion == accion)
            {

            }
        }
    }
    [Serializable]//anotacion que permite que unity pase todo
    public class EfectoSonoro
    {
        public string accion;
        public AudioClip archivoSonido;
    }
}
