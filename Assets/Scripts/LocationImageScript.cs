using UnityEngine;

public class LocationImageScript : AfterButtonPressed
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
