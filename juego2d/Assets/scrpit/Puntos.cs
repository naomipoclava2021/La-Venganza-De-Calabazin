using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Puntos : MonoBehaviour

{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void ActualizarPuntaje(float puntos)
    {
   
        texto.text = puntos.ToString();
    }
}
