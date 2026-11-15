using UnityEngine;

public class PadlockScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject padlockOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        padlockOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }
}
