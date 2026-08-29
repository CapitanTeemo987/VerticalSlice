/// <summary>
/// Este codigo se encarga de gestionar la parte de la llave,
/// esta llave permite al jugador llegar a la meta
/// </summary>
using UnityEngine;
using TMPro;

public class Llave : MonoBehaviour
{
    public GameObject puertaBloquear; 
    public TextMeshProUGUI llaveHUD;

    /// <summary>
    /// Rota la llave para darle una animacion y que no se quede asi solo estatica
    /// </summary>
    void Update()
    {
        transform.Rotate(0f, 90f * Time.deltaTime, 0f);
    }
    
    /// <summary>
    /// Le da el texto al HUD para que se actualice en cuanto el jugador recoga la llave,
    /// y desbloquea la puerta en cuando agarre la llave
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Llave recogida");
            if (llaveHUD != null)
            {
                llaveHUD.text = "Llave: 1/1";
                llaveHUD.color = Color.green;
            }
            if (puertaBloquear != null)
            {
                puertaBloquear.SetActive(false);
            }
            Destroy(gameObject);
        }
    }
}

