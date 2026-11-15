using UnityEngine;

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

            fileOverlay.SetActive(true);
            darkBackground.SetActive(true);

            return;
        }

        if (Scene(Vertices.VerticesScene.sdFolders))
        {
            clueManager.FinalCode[2].Found = true;
        }
        
    }
}
