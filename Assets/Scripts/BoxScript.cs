using UnityEngine;

public class NewMonoBehaviourScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject boxOverlay;
    [SerializeField]
    private GameObject darkBackground;
    [SerializeField]
    private Camera cam;

    public override void Pressed()
    {
        if(cam.GetComponent<CameraInput>().lens == CameraInput.lensState.nightVision)
        {
            FirstTime();

            boxOverlay.SetActive(true);
            darkBackground.SetActive(true);
        }
    }
}
