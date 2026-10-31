
        using UnityEngine;

public class PlaySoundOnClick : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip clickSound;

        private void OnMouseDown()
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
   
