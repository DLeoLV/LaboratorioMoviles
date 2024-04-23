using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBalas : MonoBehaviour
{
    public GameObject balaPrefab; 
    public float tiempoParaDisparar = 1f; 

    private bool estaPresionado = false; 
    private bool dispararHabilitado = false; 
    private float tiempoPresionado = 0f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            estaPresionado = true;
            tiempoPresionado = 0f;
        }

        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            tiempoPresionado += Time.deltaTime;
            if (tiempoPresionado >= tiempoParaDisparar && !dispararHabilitado)
            {
                dispararHabilitado = true;
                InvokeRepeating("Disparar", 0f, 1f);
            }
        }

        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            estaPresionado = false;
            if (dispararHabilitado)
            {
                dispararHabilitado = false;
                CancelInvoke("Disparar");
            }
        }
    }
    void Disparar()
    {
        Instantiate(balaPrefab, transform.position, Quaternion.identity);
    }
}
