using UnityEngine;

public class DrawerCodeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject secretDrawerOverlay;
    [SerializeField]
    private GameObject secretFileButton;

    //Placeholder
    public bool haveDrawerCode = false;

    public override void Pressed()
    {
        if(haveDrawerCode)
        {
            FirstTime();

            secretDrawerOverlay.SetActive(true);
            secretFileButton.SetActive(true);
        }
    }
}
