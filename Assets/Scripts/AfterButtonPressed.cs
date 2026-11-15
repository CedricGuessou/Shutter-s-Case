using UnityEngine;
using UnityEngine.InputSystem;

public abstract class AfterButtonPressed : MonoBehaviour
{
    // Fields

    // A way to check if the required clue is found
    [SerializeField] protected GameObject objectClue;

    // A way to updated the clues and codes found
    [SerializeField] protected ClueManager clueManager;

    // A way to keep track of where the player is
    [SerializeField] protected Vertices vertices;

    // Keep track of the active lens
    [SerializeField] protected CameraInput lens;

    protected bool firstTime = false;

    [SerializeField] protected bool photogenic;

    protected bool pictureTaken;

    public bool Photogenic
    {
        get
        {
            return photogenic;
        }
    }

    public bool PictureTaken
    {
        get
        {
            return pictureTaken;
        }
        set
        {
            pictureTaken = value;
        }
    }

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

    public bool Scene(Vertices.VerticesScene target)
    {
        return vertices.CurrentScene == target;
    }

}
