using UnityEngine;

public class PictureScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject pictureOverlay;

    public override void Pressed()
    {
        FirstTime();

        pictureOverlay.SetActive(true);
    }
}
