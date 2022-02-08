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

    bool isWalk = true;
    Rigidbody jelly;

    Animator animator;
    void Start()
    {
        
        
        
    }

    void Update()
    {
        if (isWalk)
        {

        }

    }

    /*IEnumerator MoveSlime()
    {
        while (isWalk==false)
        {
            float x = Random.Range(xMin, xMax);
            float y = Random.Range(yMin, yMax);
            Vector3 target =new Vector3(x,y,0);
            isWalk = true;
            transform.position = Vector3.Lerp(transform.position, target, speed);

            animator.SetBool("isWalk", isWalk);
            yield return new WaitForSeconds(3f);
            isWalk = false;
            
        }
    }*/
}
