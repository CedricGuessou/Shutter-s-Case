using UnityEngine;

public class SuitcaseScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject suitcaseOverlay;

    public override void Pressed()
    {
        FirstTime();

        suitcaseOverlay.SetActive(true);
    }
}
