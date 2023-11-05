using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Lab4Zad1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 1.0f;
    int objectCounter = 0;
    public int numberOfObjects;
    public GameObject block;
    public Transform platform;
    public List<Material> materials;

    void Start()
    {
        Renderer platformRenderer = platform.GetComponent<Renderer>();
        Vector3 platformCenter = platformRenderer.bounds.center;
        Vector3 platformSize = platformRenderer.bounds.size;
       
        int minX = (int)((int)platformCenter.x - platformSize.x / 2);
        int maxX = (int)((int)platformCenter.x + platformSize.x / 2);
        int minZ = (int)((int)platformCenter.z - platformSize.z / 2);
        int maxZ = (int)((int)platformCenter.z + platformSize.z / 2);
        
        List<int> pozycje_x = new List<int>(Enumerable.Range(0, numberOfObjects).Select(x => UnityEngine.Random.Range(minX, maxX)));
        List<int> pozycje_z = new List<int>(Enumerable.Range(0, numberOfObjects).Select(x => UnityEngine.Random.Range(minZ, maxZ)));


        for (int i = 0; i < numberOfObjects; i++)
        {
            positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));          
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywo³ano coroutine");
        foreach (Vector3 pos in positions)
        {
            int randomMaterialIndex = UnityEngine.Random.Range(0, materials.Count);

            GameObject cube = Instantiate(block, positions.ElementAt(objectCounter++), Quaternion.identity);    
            Renderer cubeRenderer = cube.GetComponent<Renderer>();
            cubeRenderer.material = materials[randomMaterialIndex];

            yield return new WaitForSeconds(delay);
        }
        StopCoroutine(GenerujObiekt());
    }

}