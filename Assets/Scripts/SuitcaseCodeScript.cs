using UnityEngine;

public class SuitcaseCodeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject suitcaseCodeOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        suitcaseCodeOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }
}
