using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoConAcelerometro : MonoBehaviour
{
    public float velocidadMovimiento = 5f;

    void Update()
    {
        float movimientoY = Input.acceleration.y;
        float desplazamientoY = movimientoY * velocidadMovimiento * Time.deltaTime;
        transform.Translate(Vector3.up * desplazamientoY);
    }
}