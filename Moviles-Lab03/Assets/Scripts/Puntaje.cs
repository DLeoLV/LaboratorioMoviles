using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje;
    private int puntaje = 0;

    void Start()
    {
        // Llamar a la función IncrementarPuntaje cada segundo
        InvokeRepeating("IncrementarPuntaje", 1f, 1f);
    }

    void IncrementarPuntaje()
    {
        // Incrementar el puntaje
        puntaje++;
        // Actualizar el texto del puntaje
        textoPuntaje.text = "Puntaje: " + puntaje.ToString();
    }
}