using UnityEngine;

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

    // Keep track of the active lens
    [SerializeField] private CameraInput lens;

    public override void Pressed()
    {
        if (lens.lens == lensState.nightVision && 
            Scene(Vertices.VerticesScene.desk))
        {
            FirstTime();

            vertices.CurrentScene = Vertices.VerticesScene.box;

            boxOverlay.SetActive(true);
            darkBackground.SetActive(true);
            padlockButton.SetActive(true);

            return;
        }

    }
}
