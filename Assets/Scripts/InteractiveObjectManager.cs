using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InteractiveObjectManager : MonoBehaviour
{
    private List<AfterButtonPressed> objectsToClick;

    public List<AfterButtonPressed> ObjectsToClick
    {
        get
        {
            return objectsToClick;
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        objectsToClick = new List<AfterButtonPressed>();

        List<GameObject> interactables = GameObject.FindGameObjectsWithTag("Interactable").ToList();

        foreach (GameObject item in interactables)
        {
            objectsToClick.Add(item.GetComponent<AfterButtonPressed>());
            Debug.Log(item.GetComponent<AfterButtonPressed>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
