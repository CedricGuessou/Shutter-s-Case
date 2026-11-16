using UnityEngine;
using UnityEngine.UI;

public class PictureFrameScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject frameOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        frameOverlay.GetComponent<SpriteRenderer>().enabled = true;
        darkBackground.GetComponent<SpriteRenderer>().enabled = true;
    }
}
