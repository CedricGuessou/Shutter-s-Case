using UnityEngine;

public class PulloutDrawerClosedScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject openPulloutDrawerOverlay;

    public override void Pressed()
    {
        FirstTime();

        openPulloutDrawerOverlay.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
