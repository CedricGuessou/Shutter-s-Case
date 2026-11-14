using UnityEngine;
using UnityEngine.InputSystem;

public class CameraLook : MonoBehaviour
{
    Vector2 lookMovement;

    private void Update()
    {
        // The current position of the camera in 3D space
        Vector3 cameraPos = transform.position;

        // Changes the position of the camera over time
        cameraPos += (Vector3)lookMovement * 0.001f;

        // Storing the new position
        transform.position = cameraPos;

    }


    public void OnLook(InputAction.CallbackContext ctx)
    {
        lookMovement = ctx.ReadValue<Vector2>();
    }



}
