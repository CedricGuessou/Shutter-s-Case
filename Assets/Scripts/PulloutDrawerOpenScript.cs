using UnityEngine;
using UnityEngine.UI;

public class PulloutDrawerOpenScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject closedPulloutDrawerOverlay;

    public override void Pressed()
    {
        FirstTime();

        closedPulloutDrawerOverlay.GetComponent<SpriteRenderer>().enabled = true;
        this.gameObject.GetComponent<Image>().enabled = false;
    }
}
