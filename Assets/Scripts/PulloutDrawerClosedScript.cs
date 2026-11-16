using UnityEngine;
using UnityEngine.UI;

public class PulloutDrawerClosedScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject openPulloutDrawerOverlay;

    public override void Pressed()
    {
        FirstTime();

        openPulloutDrawerOverlay.GetComponent<SpriteRenderer>().enabled = true;
        this.gameObject.GetComponent<Image>().enabled = false;
    }
}
