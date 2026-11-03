using UnityEngine;


public class PlayerJump : MonoBehaviour
{
    public float vertJumpForce = 7f;
    public float horJumpForce = 7f;
    private Rigidbody rb;
    public bool isGrounded = true;

    void Start()

    
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // add the forward force to the vertical
            rb.AddForce((Vector3.up * vertJumpForce) + (transform.forward * horJumpForce), ForceMode.Impulse);

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

    public void BedJump()
    {
        rb.AddForce((Vector3.up * vertJumpForce), ForceMode.Impulse);
    }
}


   