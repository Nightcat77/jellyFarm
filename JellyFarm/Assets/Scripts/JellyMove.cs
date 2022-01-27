using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyMove : MonoBehaviour
{
    float xMax = 5.5f;
    float xMin = -5.5f;
    float yMax = 1.25f;
    float yMin = -2.2f;

    void Start()
    {
        
    }

    void Update()
    {
        float x = Random.Range(xMin, xMax);
        float y = Random.Range(yMin, yMax);
        Vector3 target = new Vector3(x, y, 0f);
        if (transform.position.x <= xMax || transform.position.x >= xMin || transform.position.y <= yMax || transform.position.y >= yMin)
        {
        }
    }

    /*void RandomMove()
    {
        float x = Random.Range(xMin, xMax);
        float y = Random.Range(yMin, yMax);

        if(transform.position.x <= xMax || transform.position.x >= xMin || transform.position.y <= yMax || transform.position.y>= yMin)
        {
            transform.position = 
        }
    }*/
}
