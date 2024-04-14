using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExampleManager :MonoBehaviour
{

    public string[] Fruit = { "banana", "melon", "grappe" };

    public string[] Names;

    public GameObject[] Cubes;//GameObject dizisi
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log(Names[0]);
            foreach(GameObject cube in Cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.green;
            }
        }
    }
}
