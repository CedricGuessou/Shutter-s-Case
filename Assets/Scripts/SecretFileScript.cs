using UnityEngine;

public class SecretFileScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject fileOverlay;

    public override void Pressed()
    {
        FirstTime();

        fileOverlay.SetActive(true);
    }
}
