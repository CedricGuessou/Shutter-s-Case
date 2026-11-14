using System;
using Unity.VisualScripting;
using UnityEngine;

public class CameraBounds : MouseBounds
{
    [SerializeField] bool positive;
    [SerializeField] bool horizontal;
    [SerializeField] Transform parent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MouseIn)
        {
            if (horizontal)
            {
                if (positive)
                {
                    parent.position = new Vector3(parent.position.x + (float)0.1, parent.position.y, 0);
                }
                else
                {
                    parent.position = new Vector3(parent.position.x - (float)0.1, parent.position.y, 0);
                }
            }
            else
            {
                if (positive)
                {
                    parent.position = new Vector3(parent.position.x, parent.position.y + (float)0.1, 0);
                }
                else
                {
                    parent.position = new Vector3(parent.position.x, parent.position.y - (float)0.1, 0);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<MouseBehavoir>(out MouseBehavoir mouse))
        {
            mouseIn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<MouseBehavoir>(out MouseBehavoir mouse))
        {
            mouseIn = false;
        }

    }
}
