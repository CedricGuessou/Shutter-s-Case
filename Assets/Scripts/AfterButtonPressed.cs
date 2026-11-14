using UnityEngine;

public abstract class AfterButtonPressed : MonoBehaviour
{
    [SerializeField] protected GameObject objectClue;

    protected bool firstTime = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void Pressed();

    public void FirstTime()
    {
        firstTime = true;
    }

}
