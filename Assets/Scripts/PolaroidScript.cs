using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PolaroidScript : MonoBehaviour
{
    //[SerializeField]
    //private GameObject overlay;
    [SerializeField]
    private GameObject text;
    private Vector3 startPos;
    private Vector3 startScale;
    private GameObject[] otherButtons;

    private bool turnOn = true;

    //public GameObject Overlay
    //{
    //    get { return overlay; }
    //}


    public void Start()
    {
        this.gameObject.GetComponent<Image>().enabled = false;
        startPos = transform.position;
        startScale = transform.localScale;
        otherButtons = GameObject.FindGameObjectsWithTag("Picture");
    }

    public void Update()
    {
        //if (overlay.GetComponent<AfterButtonPressed>().PictureTaken)
        //{
        //    this.gameObject.SetActive(true);
        //}
    }

    public void Press()
    {
        transform.localPosition = new Vector3(-160, 0, -4091.4f);
        transform.localScale = new Vector3(12, 12, 12);
        text.SetActive(true);
        for (int i = 0; i < otherButtons.Length; i++)
        {
            if (otherButtons[i] == this.gameObject)
            {
                continue;
            }

            otherButtons[i].GetComponent<Image>().enabled = false;
        }
    }

    public void OnAttack(InputAction.CallbackContext ctx)
    {
        if(ctx.performed)
        {
            if(text.activeSelf)
            {
                transform.position = startPos;
                transform.localScale = startScale;
                text.SetActive(false);
                for (int i = 0; i < otherButtons.Length; i++)
                {
                    if (otherButtons[i] == this.gameObject)
                    {
                        continue;
                    }
                    //if(otherButtons[i].GetComponent<PolaroidScript>().Overlay.GetComponent<AfterButtonPressed>().PictureTaken)
                    //{
                    //    otherButtons[i].SetActive(true);
                    //}
                
                    if(turnOn)
                    {
                        otherButtons[i].GetComponent<Image>().enabled = true;
                    }
                
                }
            }
        }
    }
}
