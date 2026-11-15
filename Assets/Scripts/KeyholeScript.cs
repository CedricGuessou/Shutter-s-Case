using UnityEngine;

public class KeyholeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject keyholeOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        keyholeOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }
}
