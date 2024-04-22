using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTouch : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento

    private void Update()
    {
        // Si no hay toques, mover hacia abajo
        if (Input.touchCount == 0)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            return;
        }

        // Verificar si se ha tocado la pantalla
        Touch touch = Input.GetTouch(0);

        // Verificar si el toque está en la mitad superior de la pantalla
        if (touch.position.y > Screen.height / 50)
        {
            // Mover hacia arriba
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else
        {
            // Mover hacia abajo
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}