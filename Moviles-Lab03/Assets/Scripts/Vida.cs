using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    public TextMeshProUGUI textoVida;
    public int vida = 10;

    // Start is called before the first frame update
    void Start()
    {
        ActualizarVida();
    }

    void ActualizarVida()
    {
        textoVida.text = "Vida: " + vida.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            vida -= 1;
            ActualizarVida();
            if (vida <= 0)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
