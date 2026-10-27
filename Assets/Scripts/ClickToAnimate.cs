using UnityEngine;

public class ClickToAnimate : MonoBehaviour
{
    public Animator animator;



    void Start()
    {
    }

    void OnMouseDown()
    {
        animator.SetTrigger("Use");
    }


}

    
