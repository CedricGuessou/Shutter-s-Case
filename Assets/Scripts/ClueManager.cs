using UnityEngine;

public class ClueManager : MonoBehaviour
{
    // One bool for each clue
    // Index should be in order found
    Clue[] cluesFound;

    // The final pieces of the code that need to be found to complete the game
    Clue[] finalCode;

    private bool secretDrawer;

    public Clue[] CluesFound
    {
        get
        {
            return cluesFound;
        }
    }

    public Clue[] FinalCode
    {
        get
        {
            return finalCode;
        }
    }

    public bool SecretDrawer
    {
        get
        {
            return secretDrawer;
        }
        set
        {
            secretDrawer = value;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initializing the arrays
        cluesFound = new Clue[4];
        finalCode = new Clue[3];

        // Setting all the clues and codes to false
        for (int i = 0; i < cluesFound.Length; i++)
        {
            cluesFound[i].Found = false;
        }

        for (int i = 0; i < finalCode.Length; i++)
        {
            finalCode[i].Found = false;
        }
    }

    /// <summary>
    /// Finds a specified clue of the game
    /// </summary>
    /// <param name="index">The specified index</param>
    public void FindClue(int index)
    {
        cluesFound[index].Found = true;
    }

    /// <summary>
    /// Tracks all 3 pieces of the code, once all three are found the game can be complete
    /// </summary>
    public void CodeComplete()
    {
        for (int i = 0; i < finalCode.Length; i++)
        {
            if (!finalCode[i].Found)
            {
                return;
            }
        }

        // If all the codes are found, then the game is complete
        Debug.Log("Game Complete");
    }
}
