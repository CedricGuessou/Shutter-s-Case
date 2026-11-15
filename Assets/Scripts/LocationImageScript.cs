using UnityEngine;

public class LocationImageScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject pictureOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        if (Scene(Vertices.VerticesScene.finalPhoto))
        {
            FirstTime();

            pictureOverlay.SetActive(true);
            darkBackground.SetActive(true);
        }
    }
}
