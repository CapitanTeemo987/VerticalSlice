using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{

    public float velocidad = 5f; 

    private Rigidbody rb;

    private Vector3 movimiento; 

    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
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

    void FixedUpdate()  
    {
        rb.linearVelocity = new Vector3(movimiento.x * velocidad, rb.linearVelocity.y, movimiento.z * velocidad);    
    }
}
