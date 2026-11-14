using UnityEngine;

public class BookScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject bookOverlay;

    public override void Pressed()
    {
        FirstTime();

        bookOverlay.SetActive(true);
    }
}
