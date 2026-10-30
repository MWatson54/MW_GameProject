using UnityEngine;

public class SceneManager : MonoBehaviour
{

    public GameObject spawnPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger zone.");
            other.transform.position = spawnPosition.transform.position;
        }
    }
}
