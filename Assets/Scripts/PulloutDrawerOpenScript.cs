using UnityEngine;

public class PulloutDrawerOpenScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject closedPulloutDrawerOverlay;

    public override void Pressed()
    {
        FirstTime();

        closedPulloutDrawerOverlay.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
