using System;
using UnityEngine;

public class RespawnScene : MonoBehaviour
{

    public GameObject spawnPosition;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        player.transform.position = spawnPosition.transform.position;
        player.GetComponent<PlayerJump>().isGrounded = true; // Reset the isGrounded flag to true
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

            other.GetComponent<PlayerJump>().isGrounded = true; // Reset the isGrounded flag to true
        }
    }

    internal static void LoadScene(string sceneName)
    {
        throw new NotImplementedException();
    }
}
