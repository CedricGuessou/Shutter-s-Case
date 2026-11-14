using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class TypewriterPaper : AfterButtonPressed
{
    // Fields

    // The paper that appears on the screen
    [SerializeField] private GameObject paper;

    private void Start()
    {

    }

    public override void Pressed()
    {
        FirstTime();

        Debug.Log("Typewriter pressed");

        paper.transform.position = new Vector3(0, 0, 0);

    }

}
