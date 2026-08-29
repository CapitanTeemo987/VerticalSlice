using UnityEngine;

public class Llave : MonoBehaviour
{
    public GameObject puertaBloquear; 

    void Update()
    {
        transform.Rotate(0f, 90f * Time.deltaTime, 0f);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Llave recogida");
            if (puertaBloquear != null)
            {
                puertaBloquear.SetActive(false);
            }
            Destroy(gameObject);
        }
    }
}

