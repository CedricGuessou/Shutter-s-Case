using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class TypewriterPaper : AfterButtonPressed
{
    [SerializeField]
    private GameObject typewriterOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        typewriterOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }

}
