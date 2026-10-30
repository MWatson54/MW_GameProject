using UnityEngine;


public class PlayerJump : MonoBehaviour
{
    public float jumpHeight = 7f;
    private Rigidbody rb;
    private bool isGrounded = true;

    void Start()

    
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector3(
                rb.linearVelocity.x,
                jumpHeight,
                rb.linearVelocity.z);

            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}


   