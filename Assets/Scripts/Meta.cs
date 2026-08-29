/// <summary>
/// Este codgio se encarga de gestionar cuando el jugador llega a la meta 
/// </summary>
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    public ParticleSystem confetiFX;
    public GameObject panelGanaste;
    public bool detenerJuego = true;

    private bool yaGano = false;

    /// <summary>
    /// En esta funcion verificamos que algun personaje con el tag "player" haya
    /// entrado en contacto con el objeto que tiene este codigo y muestra el texto y
    /// saca particulas de confeti
    /// </summary>  
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !yaGano)
        {
            yaGano = true;
            Debug.Log("Has escapado");

            //Aqui se sacan las particulas
            if (confetiFX != null)
            {
                confetiFX.Play();
            }

            //Se activa la pantalla de ganaste
            if (panelGanaste != null)
            {
                panelGanaste.SetActive(true);
            }

            //Pausar el juego
            if (detenerJuego)
            {
                Time.timeScale = 0f;
            }

        }
    }
}