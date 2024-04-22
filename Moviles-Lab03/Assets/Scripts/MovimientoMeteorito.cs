using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMeteorito : MonoBehaviour
{
    public int velocidad;

    void Update()
    {
        transform.position = new Vector2(transform.position.x + velocidad * Time.deltaTime, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Reciclar" || collision.gameObject.tag == "Bala")
        {
            GenerarMeteoritos gen = GameObject.FindGameObjectWithTag("Generador").GetComponent<GenerarMeteoritos>();
            gen.Retornar(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GenerarMeteoritos gen = GameObject.FindGameObjectWithTag("Generador").GetComponent<GenerarMeteoritos>();
            gen.Retornar(this.gameObject);
        }
    }
}