using UnityEngine;

public class PictureScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject pictureOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        pictureOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }
}
