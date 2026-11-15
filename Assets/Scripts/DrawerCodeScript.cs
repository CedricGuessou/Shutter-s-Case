using UnityEngine;

public class DrawerCodeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject secretDrawerOverlay;
    [SerializeField]
    private GameObject secretFileButton;


    public override void Pressed()
    {
        if (Scene(Vertices.VerticesScene.desk))
        {
            FirstTime();

            vertices.CurrentScene = Vertices.VerticesScene.dCodeInput;

            secretDrawerOverlay.SetActive(true);
            secretFileButton.SetActive(true);
        }

        if (clueManager.CluesFound[2].Found && 
            Scene(Vertices.VerticesScene.dCodeInput))
        {
            clueManager.SecretDrawer = true;
        }

    }
}
