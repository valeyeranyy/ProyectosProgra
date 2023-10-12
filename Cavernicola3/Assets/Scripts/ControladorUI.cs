using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{
    public Personaje heroe;
    public Personaje etiquetaHPheroe;
    public Image barraHPHeroe;
    public Text etiquetaScore;
    // Start is called before the first frame update
    void Update()
    {
        etiquetaHPheroe.text =
            heroe.hp + "/" + heroe.hpMax;
        float porcentajeHP =
            heroe.hp / (float)heroe.hpMax;
        barraHPHeroe.fillAmount = porcentajeHP;
        etiquetaScore.text="Score" + heroe.score.ToString();
    }
   
}
