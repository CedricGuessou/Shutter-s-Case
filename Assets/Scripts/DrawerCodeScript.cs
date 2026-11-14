using UnityEngine;

public class DrawerCodeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject drawerCodeOverlay;

    public override void Pressed()
    {
        FirstTime();

        drawerCodeOverlay.SetActive(true);
    }
}
