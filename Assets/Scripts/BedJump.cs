using UnityEngine;

public class BedJump : MonoBehaviour
{
   public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered the bed trigger zone.");
            collision.gameObject.GetComponent<PlayerJump>().BedJump();
        }
    }
}
