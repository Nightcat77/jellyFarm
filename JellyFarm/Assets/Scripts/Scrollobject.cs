using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollobject : MonoBehaviour
{
    float speedMax = 0.25f;
    float speedMin = 0.1f;
    float heightMax = 3.5f;
    float heightMin = 2.5f;
    void Start()
    {

    }

    void Update()
    {
        Scroll();
    }
    void Scroll()
    {
        float speed = Random.Range(speedMin, speedMax);

        if (transform.position.x < 6) 
        {
            transform.Translate(speed*Time.deltaTime, 0, 0);
        }
        else if (transform.position.x >= 6)
        {
            speed = Random.Range(speedMin, speedMax);
            float height = Random.Range(heightMin, heightMax);
            transform.position = new Vector3(-6, height, 0);
        }
    }
}
