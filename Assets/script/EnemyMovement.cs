using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
     public float moveSpeed = 2f; 
     public float moveDistance = 3f; 

    private Vector2 startPosition; 
    private bool movingRight = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
     
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        
            if (transform.position.x >= startPosition.x + moveDistance)
            {
                movingRight = false;
            }
        }
    
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
          
            if (transform.position.x <= startPosition.x - moveDistance)
            {
                movingRight = true;
            }
        }
    }
}
