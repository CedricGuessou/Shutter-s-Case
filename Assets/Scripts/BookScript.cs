using UnityEngine;

public class BookScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject bookOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        bookOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }
}
