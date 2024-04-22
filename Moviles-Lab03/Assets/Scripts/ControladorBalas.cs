using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBalas : MonoBehaviour
{
    public GameObject balaPrefab; // Prefab de la bala a disparar
    public float tiempoParaDisparar = 1f; // Tiempo necesario para disparar despu�s de sostener presionado (en segundos)

    private bool estaPresionado = false; // Indica si el bot�n est� siendo presionado
    private bool dispararHabilitado = false; // Indica si se puede disparar
    private float tiempoPresionado = 0f; // Tiempo que se ha mantenido presionado

    void Update()
    {
        // Verificar si se presiona el bot�n
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            estaPresionado = true;
            tiempoPresionado = 0f; // Reiniciar el tiempo presionado
        }
        // Verificar si se mantiene presionado el bot�n
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            tiempoPresionado += Time.deltaTime; // Incrementar el tiempo presionado
            // Si el tiempo presionado es mayor que el tiempo para disparar, habilitar el disparo
            if (tiempoPresionado >= tiempoParaDisparar && !dispararHabilitado)
            {
                dispararHabilitado = true;
                InvokeRepeating("Disparar", 0f, 1f); // Invocar el m�todo Disparar cada segundo
            }
        }
        // Verificar si se levanta el bot�n
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            estaPresionado = false;
            // Si se estaba manteniendo presionado y ahora se levant�, cancelar el disparo
            if (dispararHabilitado)
            {
                dispararHabilitado = false;
                CancelInvoke("Disparar");
            }
        }
    }

    // M�todo para disparar una bala
    void Disparar()
    {
        Instantiate(balaPrefab, transform.position, Quaternion.identity);
    }
}
