using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using TMPro;
using System;
using Unity.VectorGraphics;
using System.Linq;

public class TextObjects : MonoBehaviour
{
    [SerializeField] InteractiveObjectManager objectManager;
    List<AfterButtonPressed> objects;

    public List<AfterButtonPressed> Objects
    {
        get
        {
            return objects;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objects = objectManager.ObjectsToClick;
        Debug.Log(objects.Count);

    }

    // Update is called once per frame
    void Update()
    {

        List<AfterButtonPressed> remove = new List<AfterButtonPressed>();

        foreach (AfterButtonPressed item in objects)
        {
            Debug.Log(item);
            Debug.Log(item.Photogenic);
            
            //if (!item.Photogenic)
            //{
            //    remove.Add(item);
            //}
        }

        foreach (AfterButtonPressed item in remove)
        {
            objects.Remove(item);
        }
    }
}
