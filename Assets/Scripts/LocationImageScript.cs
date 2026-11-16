using UnityEngine;
using UnityEngine.UI;

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

            pictureOverlay.GetComponent<SpriteRenderer>().enabled = true;
            darkBackground.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
