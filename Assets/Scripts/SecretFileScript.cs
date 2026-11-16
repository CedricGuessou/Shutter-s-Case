using UnityEngine;
using UnityEngine.UI;

public class SecretFileScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject fileOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        if (clueManager.SecretDrawer && Scene(Vertices.VerticesScene.desk))
        {
            FirstTime();

            vertices.CurrentScene = Vertices.VerticesScene.sdFolders;

            fileOverlay.GetComponent<SpriteRenderer>().enabled = true;
            darkBackground.GetComponent<SpriteRenderer>().enabled = true;

            return;
        }

        if (Scene(Vertices.VerticesScene.sdFolders))
        {
            clueManager.FinalCode[2].Found = true;
        }
        
    }
}
