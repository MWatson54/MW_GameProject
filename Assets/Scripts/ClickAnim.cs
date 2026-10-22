using UnityEngine;

public class ClickAnim : MonoBehaviour
{
    Animator animator;
    // This script is to click to trigger an animatiom on the object the script is attached to.is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
     animator.SetBool("IsClicked", true);
    }
   
}
