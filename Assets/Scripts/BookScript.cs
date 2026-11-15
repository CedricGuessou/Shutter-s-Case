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

        vertices.CurrentScene = Vertices.VerticesScene.book;
        bookOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }
}
