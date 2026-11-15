using UnityEngine;

public class PadlockScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject openBoxOverlay;
    [SerializeField]
    private GameObject darkBackground;

    //Placeholder for boolean of having the box code
    public bool haveBoxCode;

    //Current issue where both pressed and clickoff are being called at the same time
    //and the open box object isnt being shown

    public override void Pressed()
    {
        if(haveBoxCode)
        {
            FirstTime();

            openBoxOverlay.SetActive(true);
            darkBackground.SetActive(true);
        }
    }
}
