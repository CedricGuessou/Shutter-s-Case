using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraInput : MonoBehaviour
{
    Camera cam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnInteract()
    {
        
    }
}
