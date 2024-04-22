using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFondo : MonoBehaviour
{
    public float velocidadMovimiento = 5f;

    void Update()
    {
        // Mover el objeto a la izquierda
        transform.Translate(Vector2.left * velocidadMovimiento * Time.deltaTime);

        // Si el objeto llega al límite izquierdo, volver a la posición inicial
        if (transform.position.x <= -26f)
        {
            // Colocar el objeto en la posición inicial
            transform.position = new Vector3(24f, transform.position.y, 10);
        }
    }
}