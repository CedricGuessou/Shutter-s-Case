using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
public enum lensState
{
    regular,
    blacklight,
    nightVision,

}
public class CameraInput : MonoBehaviour
{
    public lensState lens;

    // References to the "shaders"
    [SerializeField] GameObject nightVision;
    [SerializeField] GameObject blackLight;

    Camera cam;
    float counter;
    Mouse mouse;
    
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
        mouse = Mouse.current;

        counter += Time.deltaTime;
        if (counter >= 0.125)
        {
            counter = (float)0.125;
        }
    }

    public void OnInteract()
    {
        foreach (AfterButtonPressed item in manager.Objects)
        {
            if ((item.transform.position - Camera.main.ScreenToWorldPoint(mouse.position.value)).x <= cam.pixelWidth / 500
                && (item.transform.position - Camera.main.ScreenToWorldPoint(mouse.position.value)).x >= -cam.pixelWidth / 500
                && (item.transform.position - Camera.main.ScreenToWorldPoint(mouse.position.value)).y <= cam.pixelHeight / 500
                && (item.transform.position - Camera.main.ScreenToWorldPoint(mouse.position.value)).y >= -cam.pixelHeight / 500)  
            {
                if (!item.PictureTaken && item.Photogenic)
                {
                    item.PictureTaken = true;
                }
            }
        }
    }

    public void OnSelect(InputAction.CallbackContext context)
    {
        int stateChange = 0;

        if (context.ReadValue<float>() > 0 && counter == 0.125)
        {
            stateChange = 1;
        }
        else if (context.ReadValue<float>() < 0 && counter == 0.125)
        {
            stateChange = -1;
        }

        if ((int)lens + stateChange >= 0 && (int)lens + stateChange <= 2)
        {
            lens = (lens + stateChange);
            counter = 0;
        }


        if (lens == lensState.blacklight)
        {
            nightVision.SetActive(false);
            blackLight.SetActive(true);
        }
        else if (lens == lensState.nightVision)
        {
            nightVision.SetActive(true);
            blackLight.SetActive(false);
        }
        else
        {
            nightVision.SetActive(false);
            blackLight.SetActive(false);
        }
    }
}
