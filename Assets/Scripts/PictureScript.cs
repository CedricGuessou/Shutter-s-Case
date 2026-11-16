using UnityEngine;
using UnityEngine.UI;

public class PictureScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject pictureOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        pictureOverlay.GetComponent<SpriteRenderer>().enabled = true;
        darkBackground.GetComponent<SpriteRenderer>().enabled = true;
    }
}
