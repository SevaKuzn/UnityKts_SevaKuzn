using System;
using System.IO.IsolatedStorage;
using UnityEngine;

public class CubeSort : MonoBehaviour
{
    private string tag = "Cube";
    private Vector3 startPos = Vector3.zero;
    private float spacing = 0.5f;
    GameObject[] cubes;

    void Start()
    {
        cubes = GameObject.FindGameObjectsWithTag(tag);
    }

    public void Sort()
    {
        BubbleSort(cubes);

        SetCubesInLine(cubes);
    }

    private void BubbleSort(GameObject[] cubes)
    {
        int length = cubes.Length;

        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - i - 1; j++)
            {
                float sizeA = cubes[j].transform.localScale.x;
                float sizeB = cubes[j + 1].transform.localScale.x;

            if (sizeA > sizeB)
                {
                    GameObject a = cubes[j];
                    cubes[j] = cubes[j + 1];
                    cubes[j + 1] = a;
                }
            }
        }
    }

    private void SetCubesInLine(GameObject[] cubes)
    {
        Vector3 currentPos = startPos;

        for (int i = 0; i < cubes.Length; i++)
        {
            float cubeWidth = cubes[i].transform.localScale.x;
            currentPos.x += cubeWidth / 2f;

            cubes[i].transform.position = new Vector3(
                currentPos.x,
                startPos.y + (cubes[i].transform.localScale.y / 2f),
                startPos.z
            );

            currentPos.x += (cubeWidth / 2f) + spacing;
        }
    }
}
