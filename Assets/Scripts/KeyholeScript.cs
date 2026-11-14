using UnityEngine;

public class KeyholeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject keyholeOverlay;

    public override void Pressed()
    {
        FirstTime();

        keyholeOverlay.SetActive(true);
    }
}
