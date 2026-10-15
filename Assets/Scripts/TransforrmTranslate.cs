using UnityEngine;

public class TransforrmTranslate : MonoBehaviour
{
    public float movementSpeed;

    public float rotationSpeed;
    
    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0,-1);

        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,0,1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1,0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1,0,0);
        }*/

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward*movementSpeed*Time.deltaTime); 
        }
        
         if (Input.GetKey(KeyCode.W))

             transform.Translate(-transform.forward*movementSpeed*Time.deltaTime);

        //rotate right
        if (Input.GetKey(KeyCode.RightArrow))
        transform.Rotate(transform.up*rotationSpeed*Time.deltaTime);
    
        {
            transform.Rotate(0, 1, 0);
        }
    }
}
