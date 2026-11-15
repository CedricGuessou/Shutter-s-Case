using UnityEngine;

public class KeyholeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject openDrawerOverlay;

    //Placeholder for the boolean of having the key clue
    public bool haveKey = false;

    public override void Pressed()
    {
        if(haveKey)
        {
            FirstTime();

            openDrawerOverlay.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
