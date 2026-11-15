using UnityEngine;

public class SuitcaseCodeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject openSuitcaseOverlay;
    [SerializeField]
    private GameObject imageButton;


    public override void Pressed()
    {
        if (Scene(Vertices.VerticesScene.Suitcase))
        {
            FirstTime();

            vertices.CurrentScene = Vertices.VerticesScene.scCodeInput;

            openSuitcaseOverlay.SetActive(true);
            imageButton.SetActive(true);
            this.gameObject.SetActive(false);

            return;
        }


        if (clueManager.CodeComplete() && 
            Scene(Vertices.VerticesScene.scCodeInput))
        {
            vertices.CurrentScene = Vertices.VerticesScene.finalPhoto;
        }
    }
}
