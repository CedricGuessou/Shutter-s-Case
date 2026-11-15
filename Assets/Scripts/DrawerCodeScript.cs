using UnityEngine;

public class DrawerCodeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject drawerCodeOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        drawerCodeOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }
}
