using UnityEngine;
using UnityEngine.InputSystem;


public class FollowMouse : MonoBehaviour
{
    Vector2 mousePosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector3)mousePosition;
    }

    void OnFollow(InputValue input)
    {
        mousePosition = Camera.main.ScreenToWorldPoint(input.Get<Vector2>());
    }
}
