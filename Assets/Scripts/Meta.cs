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

            // 1. Disparar partículas
            if (confetiFX != null)
            {
                confetiFX.Play();
            }

            // 2. Activar pantalla de victoria
            if (panelGanaste != null)
            {
                panelGanaste.SetActive(true);
            }

            // 3. Pausar el juego
            if (detenerJuego)
            {
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

            // Desactivar el collider para no volver a entrar
            GetComponent<Collider>().enabled = false;
        }
    }

    public void ReiniciarNivel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}