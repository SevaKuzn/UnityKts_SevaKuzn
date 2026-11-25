using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System;

public class BubbleSort : MonoBehaviour
{
    private List<GameObject> cubes = new List<GameObject>();
    void Start()
    {
        GameObject[] foundObjects = GameObject.FindGameObjectsWithTag("Cube");
        foreach (GameObject obj in foundObjects)
        {
            cubes.Add(obj);
        }
        Debug.Log(cubes.Count);
    }

    void Update()
    {
        
    }
}
