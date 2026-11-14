using UnityEngine;

public class ClueManager : MonoBehaviour
{
    // One bool for each clue
    // Index should be in order found
    Clue[] clues;

    public Clue[] Clues
    {
        get
        {
            return clues;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clues = new Clue[8];
        for (int i = 0; i < clues.Length; i++)
        {
            clues[i].Found = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FindClue(int index)
    {
        clues[index].Found = true;
    }
}
