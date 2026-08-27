using UnityEngine;

public class Meta : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other){

        if(other.CompareTag("Player")){
            Debug.Log("!Has escapado!");
            gameObject.SetActive(false);
        }
    }
}
