using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Zad3 : MonoBehaviour
{
    public float speed = 10.0f;
    public Vector3[] vertices = new Vector3[4];
    public int currentVertex = 0;

    void Start()
    {
        transform.position = Vector3.zero;
        vertices[0] = transform.position;
        vertices[1] = transform.position + Vector3.right * speed;
        vertices[2] = vertices[1] + Vector3.forward * speed;
        vertices[3] = vertices[2] + Vector3.left * speed;
    }

    void Update()
    {        
        Vector3 target = vertices[currentVertex];
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position == target)
        {
            currentVertex = (currentVertex + 1) % vertices.Length;

            Vector3 nextVertexDirection = (vertices[currentVertex] - transform.position).normalized;  
            Quaternion rotation = Quaternion.LookRotation(nextVertexDirection, Vector3.up);
            transform.rotation = rotation;
        }
    }
}


