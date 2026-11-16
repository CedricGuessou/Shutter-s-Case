using UnityEngine;
using UnityEngine.UI;

public class ManillaFolderScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject folderOverlay;
    [SerializeField]
    private GameObject darkBackground;

    private void Awake()
    {
        photogenic = true;
    }

    public override void Pressed()
    {
        if (Scene(Vertices.VerticesScene.folders))
        {
            FirstTime();

            folderOverlay.GetComponent<SpriteRenderer>().enabled = true;
            folderOverlay.GetComponentInChildren<SpriteRenderer>().enabled = true;
            darkBackground.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (lens.lens == lensState.blacklight)
        {
            clueManager.CluesFound[3].Found = true;
        }
        
    }
}
