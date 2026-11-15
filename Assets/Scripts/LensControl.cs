using UnityEngine;
using UnityEngine.InputSystem;

public class LensControl : MonoBehaviour
{
    [SerializeField] GameObject vision;
    [SerializeField] SpriteRenderer sprite;
    bool blackLightOn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        blackLightOn = false;
        sprite.material.SetFloat("_BlackLight", 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void BlackLight()
    {
        if (!blackLightOn)
        {
            sprite.material.SetFloat("_BlackLight", 1.0f);
            blackLightOn = true;
        }
        else
        {
            sprite.material.SetFloat("_BlackLight", 0.0f);
            blackLightOn = false;
        }
        
    }

    public void Vision()
    {
        vision.SetActive(!vision.activeSelf);
    }
}
