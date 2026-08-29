using UnityEngine;
using UnityEngine.AI; 
using UnityEngine.SceneManagement;

public class Malo : MonoBehaviour
{
    public GameObject panelPerdiste;
    public bool detenerJuego = true;
    public bool atrapado = false;

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
            MostrarDerrota();
        }
    }

    private void MostrarDerrota()
    {
        atrapado = true;
        Debug.Log("Te atraparon");

        if (panelPerdiste != null)
        {
            panelPerdiste.SetActive(true);
        }

        if (detenerJuego)
        {
            Time.timeScale = 0f;
        }
    }

    public void ReiniciarNivel()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}   