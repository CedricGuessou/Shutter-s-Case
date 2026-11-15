using UnityEngine;


public class Vertices : MonoBehaviour
{

    /// <summary>
    /// Way to keep track what is on the screen
    /// </summary>
    public enum VerticesScene
    {
        desk,
        letter,
        typewriter,
        paper,
        book,
        page,
        shelf,
        box,
        padlock,
        drawer,
        keyhole,
        folders,
        dCodeInput,
        sdFolders,
        Suitcase,
        scCodeInput,
        finalPhoto
    }

    // Field

    // keeping track of the current scene everytime
    protected VerticesScene currentScene;

    // Start at the desk
    private void Awake()
    {
        currentScene = VerticesScene.desk;
    }

    // Allows for other scripts to update the scene
    public VerticesScene CurrentScene
    {
        get
        {
            return currentScene;
        }
        set
        {
            currentScene = value;
        }
    }

}
