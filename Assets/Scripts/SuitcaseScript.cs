using UnityEngine;
using UnityEngine.UI;

public class SuitcaseScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject suitcaseOverlay;
    [SerializeField]
    private GameObject openPulloutDrawer;

    public override void Pressed()
    {
        if (Scene(Vertices.VerticesScene.desk))
        {
            FirstTime();

            vertices.CurrentScene = Vertices.VerticesScene.Suitcase;

            suitcaseOverlay.GetComponent<SpriteRenderer>().enabled = true;
            this.gameObject.GetComponent<Image>().enabled = false;
            openPulloutDrawer.GetComponent<SpriteRenderer>().enabled = true;
        }


    }
}
