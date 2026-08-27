using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    public ParticleSystem confetiFX;
    public GameObject panelGanaste;
    public bool detenerJuego = true;

    private bool yaGano = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !yaGano)
        {
            yaGano = true;
            Debug.Log("¡Has escapado!");

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