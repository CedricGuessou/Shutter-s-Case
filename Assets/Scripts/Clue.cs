using UnityEngine;

public class Clue : MonoBehaviour
{
    [SerializeField] ClueManager manager;
    [SerializeField] int index;
    bool found;

    public bool Found
    {
        get
        {
            return found;
        }
        set
        {
            found = value;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
