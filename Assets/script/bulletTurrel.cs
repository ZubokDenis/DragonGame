using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletTurrel : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 4f;
    public float lifrTime = 3f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-1, 0) * speed;
        Destroy(gameObject, lifrTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
