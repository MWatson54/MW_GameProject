using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public float openAngle = 90f;
    public float rotationSpeed = 120f;

    private bool isOpen = false;
    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        closedRotation = transform.localRotation;

        openRotation = closedRotation *
            Quaternion.Euler(0f, openAngle, 0f);
    }

    void OnMouseDown()
    {
        isOpen = !isOpen;
    }

    void Update()
    {
        Quaternion targetRotation = isOpen
            ? openRotation
            : closedRotation;

        transform.localRotation = Quaternion.RotateTowards(
            transform.localRotation,
            targetRotation,
            rotationSpeed * Time.deltaTime
        );
    }
}

    
