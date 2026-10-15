using UnityEngine;

public class TransforrmTranslate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {if (Input.GetKey(KeyCode.W))
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
        }
        
    }
}
