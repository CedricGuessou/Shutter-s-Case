using UnityEngine;
using UnityEngine.UI;

public class KeyholeScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject openDrawerOverlay;
    [SerializeField]
    private GameObject drawerKeypadButton;
    [SerializeField]
    private GameObject openKeyhole;
    [SerializeField]
    private GameObject closedKeypad;


    public override void Pressed()
    {
        if (Scene(Vertices.VerticesScene.desk))
        {
            FirstTime();

            vertices.CurrentScene = Vertices.VerticesScene.keyhole;

            openDrawerOverlay.GetComponent<SpriteRenderer>().enabled = true;
            drawerKeypadButton.GetComponent<Image>().enabled = true;
            openKeyhole.GetComponent<SpriteRenderer>().enabled = true;
            closedKeypad.GetComponent<SpriteRenderer>().enabled = false;
            this.gameObject.GetComponent<Image>().enabled = false;

            return;
        }

        if (clueManager.CluesFound[2].Found && 
            Scene(Vertices.VerticesScene.keyhole))
        {
            vertices.CurrentScene = Vertices.VerticesScene.folders;
        }
    }
}
