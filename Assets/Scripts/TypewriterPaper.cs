using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class TypewriterPaper : AfterButtonPressed
{
    // Fields

    // The paper that appears on the screen
    [SerializeField] private GameObject paper;

    
    // Methods

    /// <summary>
    /// Override - Simple way to record the first time the button is pressed
    /// and to do the actions after pressed.
    /// </summary>
    public override void Pressed()
    {
        FirstTime();

        Debug.Log("Typewriter pressed");

        paper.transform.position = new Vector3(0, 0, 0);

    }

}
