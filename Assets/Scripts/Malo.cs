/// <summary>
/// Este codigo se encarga de manejar al personaje malo del juego, utilize
/// la herramienda de NavMeshAgent para que el malo no chocara tanto con las 
/// paredes
/// </summary>
using UnityEngine;
using UnityEngine.AI; 
using UnityEngine.SceneManagement;

public class Malo : MonoBehaviour
{
    public GameObject panelPerdiste;
    public bool detenerJuego = true;

    private Transform jugador;
    private NavMeshAgent agente;
    
    /// <summary>
    /// Aqui simplemente asignamos las referencias a las variables jugador y agente
    /// </summary>
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
        agente = GetComponent<NavMeshAgent>();
    }

    /// <summary>
    /// Mandamos al malo a la posicion del jugador
    /// </summary>
    void Update()
    {
            agente.SetDestination(jugador.position);
    }

    /// <summary>
    /// Si el malo choca con alguin juegador llama a la funcion mostrarderrota
    /// </summary>
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MostrarDerrota();
        }
    }

    /// <summary>
    /// Esta funcion se encarga de mostrar el panel de perdiste y pausa el juego
    /// </summary>
    private void MostrarDerrota()
    {
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

    /// <summary>
    /// Esta funcion la voy a usar para el boton de volver a jugar
    /// </summary>
    public void ReiniciarNivel()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}   