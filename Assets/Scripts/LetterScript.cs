using UnityEngine;
using UnityEngine.InputSystem;

public class LetterScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject letterOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();
        
        letterOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }
}
