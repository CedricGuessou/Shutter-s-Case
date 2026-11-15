using UnityEngine;

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

            openDrawerOverlay.SetActive(true);
            drawerKeypadButton.SetActive(true);
            openKeyhole.SetActive(true);
            closedKeypad.SetActive(false);
            this.gameObject.SetActive(false);

            return;
        }

        if (clueManager.CluesFound[2].Found && 
            Scene(Vertices.VerticesScene.keyhole))
        {
            vertices.CurrentScene = Vertices.VerticesScene.folders;
        }
    }
}
