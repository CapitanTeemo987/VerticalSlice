using UnityEngine;
using UnityEngine.AI; 
using UnityEngine.SceneManagement;

public class Malo : MonoBehaviour
{
    private Transform jugador;
    private NavMeshAgent agente;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
        agente = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
            agente.SetDestination(jugador.position);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}