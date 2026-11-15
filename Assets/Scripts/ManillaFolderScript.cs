using UnityEngine;

public class ManillaFolderScript : AfterButtonPressed
{
    [SerializeField]
    private GameObject folderOverlay;
    [SerializeField]
    private GameObject darkBackground;

    public override void Pressed()
    {
        FirstTime();

        folderOverlay.SetActive(true);
        darkBackground.SetActive(true);
    }
}
