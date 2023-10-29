using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad5 : MonoBehaviour
{
    public GameObject Prefab;
    public int numberOfObjects = 10;
    
    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            GameObject cube = Instantiate(Prefab, new Vector3(0, 0, 0), Quaternion.identity);
            cube.transform.position = new Vector3(Random.Range(-40.0f, 40.0f), 3, Random.Range(-40.0f, 40.0f));
        }
    }
}
