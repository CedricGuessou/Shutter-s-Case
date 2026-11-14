using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class TypewriterPaper : AfterButtonPressed
{
    // Fields
    private Button typeWriter;

    private void Start()
    {
        typeWriter = gameObject.GetComponent<Button>();
    }

    public override void Pressed()
    {
        FirstTime();

        Debug.Log("Typewriter pressed");
    }

}
