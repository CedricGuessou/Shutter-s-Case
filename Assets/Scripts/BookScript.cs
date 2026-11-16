using UnityEngine;
using UnityEngine.UI;

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
        bookOverlay.GetComponent<SpriteRenderer>().enabled = true;
        darkBackground.GetComponent<SpriteRenderer>().enabled = true;
    }
}
