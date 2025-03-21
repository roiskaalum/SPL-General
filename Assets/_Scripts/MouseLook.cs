using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody; // Reference to the player body for horizontal rotation

    private float xRotation = 0f;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Locks the cursor to the center of the screen
    }

    public void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Prevents flipping

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // Vertical rotation (camera only)
        playerBody.Rotate(Vector3.up * mouseX); // Horizontal rotation (player body)
    }
}
