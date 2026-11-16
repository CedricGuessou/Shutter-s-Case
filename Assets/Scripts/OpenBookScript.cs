using UnityEngine;

public class OpenBookScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject bookOverlay;
    [SerializeField]
    private GameObject darkBackground;

    private void Awake()
    {
        photogenic = true;
    }

    public override void Pressed()
    {
        if (Scene(Vertices.VerticesScene.desk))
        {
            FirstTime();

            vertices.CurrentScene = Vertices.VerticesScene.page;
            bookOverlay.GetComponent<SpriteRenderer>().enabled = true;
            darkBackground.GetComponent<SpriteRenderer>().enabled = true;

            return;
        }

        if (Scene(Vertices.VerticesScene.page) && clueManager.CluesFound[0].Found) 
        {
            clueManager.CluesFound[1].Found = true;
        }
        
    }
}
