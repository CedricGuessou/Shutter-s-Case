using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class TypewriterPaper : AfterButtonPressed
{
    [SerializeField]
    private GameObject typewriterOverlay;

    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        vertices.CurrentScene = Vertices.VerticesScene.typewriter;

        typewriterOverlay.GetComponent<SpriteRenderer>().enabled = true;
        darkBackground.GetComponent<SpriteRenderer>().enabled = true;
    }

}
