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

    //Placeholder for lens logic
    public bool isNightVision = false;

    public override void Pressed()
    {
        if(isNightVision)
        {
            FirstTime();

            boxOverlay.SetActive(true);
            darkBackground.SetActive(true);
            padlockButton.SetActive(true);
        }
    }
}
