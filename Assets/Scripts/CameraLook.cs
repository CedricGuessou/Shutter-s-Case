using UnityEngine;
using UnityEngine.InputSystem;

public class CameraLook : MonoBehaviour
{
    [SerializeField] GameObject background;
    Camera cam;
    Vector2 lookMovement;

    private void Awake()
    {
        cam = gameObject.GetComponent<Camera>();
    }

    private void Update()
    {
        // The current position of the camera in 3D space
        Vector3 cameraPos = transform.position;

        // Changes the position of the camera over time
        cameraPos += (Vector3)lookMovement * 0.005f;


        // Checking if the camera is within the bounds of the background
        //if ((cameraPos - background.transform.position).x + cam.pixelWidth/200 >= background.transform.localScale.x / 2)
        //{
        //    cameraPos = new Vector3(background.transform.localScale.x / 2 - cam.pixelWidth / 200, cameraPos.y);
        //}
        //else if ((cameraPos - background.transform.position).x - cam.pixelWidth / 200 <= -background.transform.localScale.x / 2)
        //{
        //    cameraPos = new Vector3(-background.transform.localScale.x / 2 + cam.pixelWidth / 200, cameraPos.y);
        //}
        //
        //if ((cameraPos - background.transform.position).y + cam.pixelHeight / 200 >= background.transform.localScale.y / 2)
        //{
        //    cameraPos = new Vector3(cameraPos.x, background.transform.localScale.y / 2 - cam.pixelHeight / 200);
        //}
        //else if ((cameraPos - background.transform.position).y - cam.pixelHeight / 200 <= -background.transform.localScale.y / 2)
        //{
        //    cameraPos = new Vector3(cameraPos.x, background.transform.localScale.y / 2 + cam.pixelHeight / 200);
        //}


        cameraPos += (Vector3)lookMovement * 0.005f;

        // Storing the new position
        transform.position = cameraPos;
    }

    public void OnLook(InputAction.CallbackContext ctx)
    {
        lookMovement = ctx.ReadValue<Vector2>();
    }
}
