using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class LetterScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject letterOverlay;
    [SerializeField]
    private GameObject darkBackground;

    private void Awake()
    {
        photogenic = true;
    }

    public override void Pressed()
    {
        FirstTime();
        
        letterOverlay.GetComponent<SpriteRenderer>().enabled = true;
        darkBackground.GetComponent<SpriteRenderer>().enabled = true;
    }
}
