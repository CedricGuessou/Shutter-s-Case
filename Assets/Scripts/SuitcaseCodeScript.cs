using UnityEngine;
using UnityEngine.UI;

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

            openSuitcaseOverlay.GetComponent<SpriteRenderer>().enabled = true;
            imageButton.GetComponent<Image>().enabled = true;
            this.gameObject.GetComponent<Image>().enabled = false;

            return;
        }


        if (clueManager.CodeComplete() && 
            Scene(Vertices.VerticesScene.scCodeInput))
        {
            vertices.CurrentScene = Vertices.VerticesScene.finalPhoto;
        }
    }
}
