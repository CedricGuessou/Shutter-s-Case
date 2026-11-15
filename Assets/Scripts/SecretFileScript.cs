using UnityEngine;

public class SecretFileScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject fileOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        fileOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }
}
