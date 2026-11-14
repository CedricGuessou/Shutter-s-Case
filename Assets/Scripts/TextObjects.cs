using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using TMPro;
using System;

public class TextObjects : MonoBehaviour
{
    List<GameObject> objects;

    public List<GameObject> Objects
    {
        get
        {
            return objects;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objects = new List<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
           
    }
}
