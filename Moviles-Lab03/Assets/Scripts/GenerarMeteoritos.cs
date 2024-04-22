using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarMeteoritos : MonoBehaviour
{
    public GameObject obstaculo;
    public List<GameObject> Reciclaje;
    GameObject enemy;
    public Vector2 posicionPartida;
    public float yMin;
    public float yMax;

    private void Awake()
    {
        // Inicializar la lista del pool
        Reciclaje = new List<GameObject>();

        // Crear los enemigos iniciales y agregarlas al pool
        for (int i = 0; i < 20; i++)
        {
            enemy = Instantiate(obstaculo);


            enemy.SetActive(false); // Desactivar la bala para que no sea visible ni interaccione
            Reciclaje.Add(enemy);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarEnemigo", 0, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerarEnemigo()
    {

        if (Reciclaje.Count > 0)
        {
            float randY = Random.Range(yMin, yMax);
            posicionPartida.y = randY;

            Reciclaje.RemoveAt(0);
            Reciclaje[0].transform.position = posicionPartida;
            Reciclaje[0].SetActive(true);
        }


    }

    public void Retornar(GameObject enemy)
    {
        enemy.SetActive(false);
        Reciclaje.Add(enemy);
    }
}
