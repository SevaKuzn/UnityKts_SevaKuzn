using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System;

public class BubbleSort : MonoBehaviour
{
    private List<GameObject> cubes = new List<GameObject>();
    [SerializeField] private Transform sortPos;
    private float sortNumber = 0;
    private float addRange = 0;
    void Start()
    {
        GameObject[] foundObjects = GameObject.FindGameObjectsWithTag("Cube");
        foreach (GameObject obj in foundObjects)
        {
            cubes.Add(obj);
        }
        //cubes.Sort();
    }

    void Update()
    {
        
    }

    public void Sort()
    {
        foreach (GameObject obj in cubes) 
        {
            if (obj.transform.localScale[0] >= sortNumber)
            {
                sortNumber = obj.transform.localScale[0];
                obj.transform.position = new Vector3(0f + addRange, 0f, 0f);
                addRange += 4f;
            }
            else
            {
                Debug.Log("123");
            }
        }
    }
}
