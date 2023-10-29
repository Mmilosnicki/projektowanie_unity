using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad2 : MonoBehaviour
{
    public float speed = 5.0f;
    public Vector3 start = new Vector3(0.0f, 0.0f, 0.0f);
    public Vector3 meta = new Vector3(10.0f, 0.0f, 0.0f);
    private bool moving;
  
    void Start()
    {
        transform.position = start;
    }

    void Update()
    {
        if(moving)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }   
        
        if(transform.position.x >= meta.x)
        {
            moving = false;
        }      
        else if(transform.position.x <= start.x)
        {
            moving = true;
        }
            
    }
}
