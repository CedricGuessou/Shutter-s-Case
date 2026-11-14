using UnityEngine;

public class ClueManager : MonoBehaviour
{
    // One bool for each clue
    // Index should be in order found
    Clue[] cluesFound;

    public Clue[] CluesFound
    {
        get
        {
            return cluesFound;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cluesFound = new Clue[7];
        for (int i = 0; i < cluesFound.Length; i++)
        {
            cluesFound[i].Found = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FindClue(int index)
    {
        cluesFound[index].Found = true;
    }
}
