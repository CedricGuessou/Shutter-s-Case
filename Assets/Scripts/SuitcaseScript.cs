using UnityEngine;

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

            suitcaseOverlay.SetActive(true);
            this.gameObject.SetActive(false);
            openPulloutDrawer.SetActive(true);
        }


        
    }
}
