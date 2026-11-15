using UnityEngine;

public class SuitcaseCodeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject openSuitcaseOverlay;

    //Placeholder
    public bool haveFinalCode;

    public override void Pressed()
    {
        if(haveFinalCode)
        {
            FirstTime();

            openSuitcaseOverlay.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
