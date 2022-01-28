using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyMove : MonoBehaviour
{
    float xMax = 5.5f;
    float xMin = -5.5f;
    float yMax = 1.25f;
    float yMin = -2.2f;
    float speed = 0.5f;
    float moveCount = 0;
    Rigidbody jelly;
    void Start()
    {
        
        
        StartCoroutine(MoveSlime());
    }

    void Update()
    {
       

    }

    IEnumerator MoveSlime()
    {
        jelly = GetComponent<Rigidbody>();
        while (true)
        {
            float x = Random.Range(xMin, xMax);
            float y = Random.Range(yMin, yMax);
            Vector3 target =new Vector3(x,y,0);
            
            yield return new WaitForSeconds(3f);
            jelly.velocity = new Vector3(x, y, 0);
            
        }
    }
}
