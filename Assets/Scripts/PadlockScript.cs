using UnityEngine;

public class PadlockScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject padlockOverlay;

    public override void Pressed()
    {
        FirstTime();

        padlockOverlay.SetActive(true);
    }
}
