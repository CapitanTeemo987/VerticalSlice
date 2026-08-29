using UnityEngine;
using UnityEngine.SceneManagement;

public class Malo : MonoBehaviour
{
    public float velocidad = 12f;
    private Transform jugador;
    private Rigidbody rb;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();    
    }

    void FixedUpdate()
    {
        Vector3 direccion = jugador.position - transform.position;
        direccion.y = 0f;
        direccion = direccion.normalized;

        //Para el problema que el malo atravesaba las paredes
        rb.linearVelocity = direccion * velocidad;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}