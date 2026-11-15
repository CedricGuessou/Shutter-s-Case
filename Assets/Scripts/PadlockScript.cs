using UnityEngine;

public class PadlockScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject openBoxOverlay;
    [SerializeField]
    private GameObject darkBackground;

    //Placeholder for boolean of having the box code
    public bool haveBoxCode;

    //Current issue where both pressed and clickoff are being called at the same time
    //and the open box object isnt being shown

    public override void Pressed()
    {
        if (haveBoxCode && Scene(Vertices.VerticesScene.box))
        {
            FirstTime();

            vertices.CurrentScene = Vertices.VerticesScene.padlock;

            openBoxOverlay.SetActive(true);
            darkBackground.SetActive(true);

            return;
        }

        if (Scene(Vertices.VerticesScene.padlock) && clueManager.CluesFound[1].Found)
        {
            clueManager.CluesFound[2].Found = true;
            clueManager.FinalCode[1].Found = true;
        }

    }
}
