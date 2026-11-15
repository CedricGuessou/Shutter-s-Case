using UnityEngine;

public class PaperScript : AfterButtonPressed
{
    // Fields

    // Keep track of the active lens
    [SerializeField] private CameraInput lens;

    public override void Pressed()
    {
        if (Scene(Vertices.VerticesScene.desk))
        {
            FirstTime();

            vertices.CurrentScene = Vertices.VerticesScene.paper;
        }
        
        if (Scene(Vertices.VerticesScene.paper) &&
            lens.lens == lensState.blacklight)
        {
            clueManager.CluesFound[0].Found = true;
            clueManager.FinalCode[0].Found = true;
        }

    }


}
