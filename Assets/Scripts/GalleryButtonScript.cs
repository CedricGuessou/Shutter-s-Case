using UnityEngine;

public class GalleryButtonScript : MonoBehaviour
{
    [SerializeField]
    private GameObject background;
    [SerializeField]
    private GameObject pictures;

    public void Press()
    {
        background.SetActive(!background.activeSelf);
        pictures.SetActive(!pictures.activeSelf);
    }
}
