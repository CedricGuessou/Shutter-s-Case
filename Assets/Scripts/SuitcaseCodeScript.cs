using UnityEngine;

public class SuitcaseCodeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject suitcaseCodeOverlay;

    public override void Pressed()
    {
        FirstTime();

        suitcaseCodeOverlay.SetActive(true);
    }
}
