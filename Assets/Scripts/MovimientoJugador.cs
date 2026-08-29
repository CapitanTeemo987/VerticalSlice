/// <summary>
/// Aqui es para mover al jugador y las animaciones
/// </summary>
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{

    public float velocidad = 5f; 
    private Rigidbody rb;
    private Vector3 movimiento; 
    private Animator animator;

    /// <summary>
    /// Se asinan las referencias al rigidbody y al animator del jugador
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    /// <summary>
    /// En esta parte es para la animacion del jugador, lee la entrada del jugador,
    /// actualiza la animacion y normaliza las direcciones, 
    /// es codigo que hicimos en la clase
    /// </summary>
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        movimiento = new Vector3(x, 0f, z).normalized; 

        if(animator != null)
        {
            animator.SetFloat("velocidad", movimiento.magnitude);
        }
        if(movimiento.sqrMagnitude > 0.01f)
        {
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(movimiento),
                12f*Time.deltaTime
            );
        }
    }
    
    /// <summary>
    /// Aqui se donde el personaje se mueve con la velocidad asignada
    /// </summary>
    void FixedUpdate()  
    {
        rb.linearVelocity = new Vector3(movimiento.x * velocidad, rb.linearVelocity.y, movimiento.z * velocidad);    
    }
}
