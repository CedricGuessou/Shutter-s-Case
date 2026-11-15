using UnityEngine;

public class PadlockScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject openBoxOverlay;
    [SerializeField]
    private GameObject darkBackground;

    //Placeholder for boolean of having the box code
    public bool haveBoxCode;

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
