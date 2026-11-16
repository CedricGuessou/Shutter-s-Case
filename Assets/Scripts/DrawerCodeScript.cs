using UnityEngine;
using UnityEngine.UI;

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

            secretDrawerOverlay.GetComponent<SpriteRenderer>().enabled = true;
            secretFileButton.GetComponent<Image>().enabled = true;
        }

        if (clueManager.CluesFound[2].Found && 
            Scene(Vertices.VerticesScene.dCodeInput))
        {
            clueManager.SecretDrawer = true;
        }

    }
}
