using UnityEngine;

public class ClickToAnimate : MonoBehaviour
{
    public Animator animator;
    public AudioSource AudioSource;
    public AudioClip AudioClip;



    void Start()
    {
    }

    void OnMouseDown()
    {
        OpenDoor();
    }

    public void OpenDoor()
    {
        animator.SetTrigger("Use");
        //AudioSource.PlayOneShot(AudioClip);
    }

    // void OnTriggerEnter(Collider other)
    // {


    // }


}

    
