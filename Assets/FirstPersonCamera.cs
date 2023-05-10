using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    // variables
    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0f;
    bool lockedCurser = true;

    // Start is called before the first frame update
    void Start()
    {
        // lock and hide the cursor
        //Cursor.visible = false;
       // Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Collect Mouse Input
        float InputX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float InputY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // rotate the camera around its local X axis
        cameraVerticalRotation -= InputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

        // rotate the player object and the camera around its Y axis
        player.Rotate(Vector3.up * InputX);
    }
}
