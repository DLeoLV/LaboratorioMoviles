using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDeEscenas : MonoBehaviour
{
    public void CargarJuego()
    {
        SceneManager.LoadScene("Juego");
    }
}
