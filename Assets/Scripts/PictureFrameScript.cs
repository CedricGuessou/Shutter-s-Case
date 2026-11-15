using UnityEngine;

public class PictureFrameScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject frameOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        frameOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }
}
