using UnityEngine;
//This script is for a Debug Log Statement


public class HelloWorldDebug : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
      void OnEnable()
    {
        Debug.Log("Hello World");
    }
    
    
    void OnMouseDown (){
    Debug.Log("Hello World");   
    }

    // Update is called once per frame
    void OnDisable()
    {
        Debug.Log("Goodbye World");

    }
    
}
