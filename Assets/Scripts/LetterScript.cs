using UnityEngine;
using UnityEngine.InputSystem;

public class LetterScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject letterOverlay;

    public override void Pressed()
    {
        FirstTime();
        
        letterOverlay.SetActive(true);
    }
}
