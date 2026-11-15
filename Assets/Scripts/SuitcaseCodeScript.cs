using UnityEngine;

public class SuitcaseCodeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject openSuitcaseOverlay;
    [SerializeField]
    private GameObject imageButton;

    //Placeholder
    public bool haveFinalCode;

    public override void Pressed()
    {
        if(haveFinalCode)
        {
            FirstTime();

            openSuitcaseOverlay.SetActive(true);
            imageButton.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
