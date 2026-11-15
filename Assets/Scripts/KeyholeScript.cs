using UnityEngine;

public class KeyholeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject openDrawerOverlay;
    [SerializeField]
    private GameObject drawerKeypadButton;
    [SerializeField]
    private GameObject openKeyhole;
    [SerializeField]
    private GameObject closedKeypad;

    //Placeholder for the boolean of having the key clue
    public bool haveKey = false;

    public override void Pressed()
    {
        if(haveKey)
        {
            FirstTime();

            openDrawerOverlay.SetActive(true);
            drawerKeypadButton.SetActive(true);
            openKeyhole.SetActive(true);
            closedKeypad.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
