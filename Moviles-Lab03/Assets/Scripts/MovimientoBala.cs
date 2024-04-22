using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    // Velocidad de la bala
    public float velocidad = 5f;

    // Método que se llama en cada frame
    void Update()
    {
        // Mover la bala hacia la derecha
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    // Método que se llama cuando la bala colisiona con otro objeto
    void OnTriggerEnter2D(Collider2D other)
    {
        // Comprobar si el objeto tiene el tag "Muro"
        if (other.CompareTag("Reciclar") || other.CompareTag("Obstaculo"))
        {
            // Destruir la bala
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            Destroy(this.gameObject);
        }
    }
}