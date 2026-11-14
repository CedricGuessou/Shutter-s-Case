using UnityEngine;
using System.Collections.Generic;

public class InteractiveObjectManager : MonoBehaviour
{
    private List<GameObject> objectsToClick;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectsToClick = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
