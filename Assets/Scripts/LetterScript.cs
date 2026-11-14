using UnityEngine;
using UnityEngine.InputSystem;

public class LetterScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject letterOverlay;

    private bool overlayActive;

    public override void Pressed()
    {
        FirstTime();
        
        letterOverlay.SetActive(true);
    }
}
