using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public Camera cam;
    public float mouseSensitivity = 100f;
    private float xRotation = 0, yRotation = 0;

    void Start() => Cursor.lockState = CursorLockMode.Locked;
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        yRotation += mouseX;
        transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
