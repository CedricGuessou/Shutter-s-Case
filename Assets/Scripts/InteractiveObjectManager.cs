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
    void Start()
    {
        objectsToClick = GameObject.FindObjectsByType<AfterButtonPressed>(FindObjectsSortMode.InstanceID).ToList<AfterButtonPressed>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
