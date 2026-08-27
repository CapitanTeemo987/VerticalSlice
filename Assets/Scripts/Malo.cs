using UnityEngine;
using UnityEngine.SceneManagement;

public class Malo : MonoBehaviour
{
    public float velocidad = 12f;

    private Transform jugador;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Vector3 direccion = jugador.position - transform.position;

        direccion.y = 0f;

        direccion = direccion.normalized;

        transform.position += direccion * velocidad * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}