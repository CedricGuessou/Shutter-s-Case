using UnityEngine;
using UnityEngine.UI;

public class GalleryButtonScript : MonoBehaviour
{
    [SerializeField]
    private GameObject background;
    [SerializeField]
    private GameObject pictures;

    public void Press()
    {
        background.GetComponent<SpriteRenderer>().enabled = !(background.GetComponent<SpriteRenderer>().enabled);
        pictures.GetComponent<SpriteRenderer>().enabled = !(pictures.GetComponent<SpriteRenderer>().enabled);
    }
}
