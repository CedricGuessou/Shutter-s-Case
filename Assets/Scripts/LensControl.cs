using UnityEngine;
using UnityEngine.InputSystem;

public class LensControl : MonoBehaviour
{
    [SerializeField] GameObject nightVision;
    [SerializeField] GameObject blackLight;
    [SerializeField] CameraInput cameraInput;
    bool blackLightOn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        blackLightOn = false;
        // sprite.material.SetFloat("_BlackLight", 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void BlackLight()
    {
        if (!blackLightOn)
        {
            // .material.SetFloat("_BlackLight", 1.0f);
            blackLightOn = true;
        }
        else
        {
           //  sprite.material.SetFloat("_BlackLight", 0.0f);
            blackLightOn = false;
        }
        
    }

    public void Vision(GameObject lens)
    {
        lens.SetActive(!lens.activeSelf);
    } 

    public void ActivateLens()
    {
        switch (cameraInput.lens)
        {
            case lensState.regular:
                break;

            case lensState.blacklight:
                Vision(blackLight);
                break;

            case lensState.nightVision:
                Vision(nightVision);
                break;

            default:
                break;
        }
    }
}
