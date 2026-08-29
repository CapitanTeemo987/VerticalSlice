/// <summary>
/// Era para que la camara siguiera al jugador, pero me decidi por una camara fija
/// </summary>
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    /// <summary>
    /// el offset calcula cuanto se separa la camara del jugador
    /// </summary>
    void Start()
    {
        if (player != null)
        {
            offset = transform.position - player.transform.position;
        }
    }

    /// <summary>
    /// con el offset la camara se mantiene a una distancia fija respecto al jugador
    /// </summary>
    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
    }
}