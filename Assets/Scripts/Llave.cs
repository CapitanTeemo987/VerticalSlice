using UnityEngine;
using TMPro;

public class Llave : MonoBehaviour
{
    public GameObject puertaBloquear; 
    public TextMeshProUGUI llaveHUD;

    void Update()
    {
        transform.Rotate(0f, 90f * Time.deltaTime, 0f);
    }
    
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

