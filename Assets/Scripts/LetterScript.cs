using UnityEngine;
using UnityEngine.InputSystem;

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
        
        letterOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }
}
