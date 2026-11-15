using UnityEngine;

public class PaperScript : AfterButtonPressed
{
    // Fields

    // Keep track of the active lens
    [SerializeField] private CameraInput lens;

    public override void Pressed()
    {
        if (vertices.CurrentScene == Vertices.VerticesScene.typewriter)
        {
            FirstTime();

            vertices.CurrentScene = Vertices.VerticesScene.paper;
        }
        
        if (vertices.CurrentScene == Vertices.VerticesScene.paper &&
            lens.lens == lensState.blacklight)
        {
            clueManager.CluesFound[0].Found = true;
            clueManager.FinalCode[0].Found = true;
        }

    }


}
