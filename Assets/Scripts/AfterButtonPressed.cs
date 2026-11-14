using UnityEngine;
using UnityEngine.InputSystem;

public abstract class AfterButtonPressed : MonoBehaviour
{
    // Fields

    // A way to check if the required clue is found
    [SerializeField] protected GameObject objectClue;

    // A way to updated the clues and codes found
    [SerializeField] protected ClueManager clueManager;

    protected Vertices vertices;

    protected bool firstTime = false;

    protected bool photogenic;

    // Methods

    public void Awake()
    {
         
    }

    /// <summary>
    /// Abstract - Meant to be called in the children classes
    /// </summary>
    public abstract void Pressed();

    /// <summary>
    /// When the button is pressed for the first time, this will become true.
    /// Made to be used to start other processes or events
    /// </summary>
    public void FirstTime()
    {
        firstTime = true;
    }

}
