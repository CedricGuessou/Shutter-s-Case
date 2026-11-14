using UnityEngine;

public class NewMonoBehaviourScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject boxOverlay;

    public override void Pressed()
    {
        FirstTime();

        boxOverlay.SetActive(true);
    }
}
