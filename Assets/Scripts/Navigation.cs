using UnityEngine;

public class Navigation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
   public float mySpeed;//my speed variable
    //remember to set the values in the Inspector in Unity

    void Update()
    {
        BetterMovement();//Uncomment this name by deleting the // before the namespace to call this method.
    }

    

    void BetterMovement()//this script moves GameObjects in RealTime
    {
         if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.forward*mySpeed*Time.deltaTime, Space.World);//old way of moving - moves 1 unit per frame 
            Debug.Log("Up Arrow is pressed and the position is " + transform.position);
        }
        
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate((-1)*transform.forward*mySpeed*Time.deltaTime, Space.World);//new way of moving
            Debug.Log("Down Arrow is pressed and the position is " + transform.position);
        }
           if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate((-1)*transform.right*mySpeed*Time.deltaTime, Space.World);//old way of moving - moves 1 unit per frame  
            Debug.Log("Left Arrow is pressed and the position is " + transform.position);
        }
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(transform.right*mySpeed*Time.deltaTime, Space.World);//old way of moving - moves 1 unit per frame  
            Debug.Log("Right Arrow is pressed and the position is " + transform.position);
        }
    }



}