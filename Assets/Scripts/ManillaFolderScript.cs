using UnityEngine;

public class ManillaFolderScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject folderOverlay;

    public override void Pressed()
    {
        FirstTime();

        folderOverlay.SetActive(true);
    }
}
