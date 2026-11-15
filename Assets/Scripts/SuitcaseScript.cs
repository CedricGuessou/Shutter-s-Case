using UnityEngine;

public class SuitcaseScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject suitcaseOverlay;
    [SerializeField]
    private GameObject openPulloutDrawer;

    public override void Pressed()
    {
        FirstTime();

        suitcaseOverlay.SetActive(true);
        this.gameObject.SetActive(false);
        openPulloutDrawer.SetActive(true);
    }
}
