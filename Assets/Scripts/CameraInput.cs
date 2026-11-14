using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraInput : MonoBehaviour
{
    public enum lensState
    {
        regular,
        blacklight,
        nightVision,

    }

    lensState lens;
    Camera cam;
    float counter;
    
    [SerializeField] TextObjects manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = gameObject.GetComponent<Camera>();
        lens = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 0.25)
        {
            counter = (float)0.25;
        }
    }

    public void OnInteract()
    {
        foreach (GameObject item in manager.Objects)
        {
            if ((item.transform.position - cam.transform.position).x <= cam.pixelHeight / 200
                && (item.transform.position - cam.transform.position).x >= -cam.pixelHeight / 200
                && (item.transform.position - cam.transform.position).y <= cam.pixelHeight / 200
                && (item.transform.position - cam.transform.position).y >= -cam.pixelHeight / 200)  
            {

            }
        }
    }

    public void OnSelect(InputAction.CallbackContext context)
    {
        int stateChange = 0;

        if (context.ReadValue<float>() > 0 && counter == 0.25)
        {
            stateChange = 1;
            counter = 0;
        }
        else if (context.ReadValue<float>() < 0 && counter == 0.25)
        {
            stateChange = -1;
            counter = 0;
        }

        if ((int)lens + stateChange >= 0 && (int)lens + stateChange <= 2)
        {
            lens = (lens + stateChange);
        }
    }
}
