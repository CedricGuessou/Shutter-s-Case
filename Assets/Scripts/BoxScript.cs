using UnityEngine;
using UnityEngine.UI;

public class BoxScript: AfterButtonPressed
{
    [SerializeField]
    private GameObject boxOverlay;
    [SerializeField]
    private GameObject padlockButton;
    [SerializeField]
    private GameObject darkBackground;
    [SerializeField]
    private Camera cam;

    public override void Pressed()
    {
        if (lens.lens == lensState.nightVision && 
            Scene(Vertices.VerticesScene.desk))
        {
            FirstTime();

            vertices.CurrentScene = Vertices.VerticesScene.box;

            boxOverlay.GetComponent<SpriteRenderer>().enabled = true;
            darkBackground.GetComponent<SpriteRenderer>().enabled = true;
            padlockButton.GetComponent<Image>().enabled = true;

            return;
        }

    }
}
