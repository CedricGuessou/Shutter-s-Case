using UnityEngine;

public class Clue : MonoBehaviour
{
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

}
