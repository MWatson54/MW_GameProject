
        using UnityEngine;

public class PlaySoundWhenJumpedOn : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip bounceSound;

        private void OnCollisionEnter(Collision collision)
        {
            // Check if the player landed on this object
            if (collision.gameObject.CompareTag("Player"))
            {
                audioSource.PlayOneShot(bounceSound);
            }
        }
    }

    
    
